import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/common_widgets/master_screen.dart';
import 'package:provider/provider.dart';

import '../../../constants/image_strings.dart';
import '../controllers/objectives_provider.dart';
import '../controllers/project_provider.dart';
import '../controllers/votes_provider.dart';
import '../models/objective.dart';
import '../models/project.dart';
import '../models/vote.dart';

class ProjectDetailsScreen extends StatefulWidget {
  static const String routeName = "/project_details";
  String id;

  ProjectDetailsScreen(this.id, {Key? key}) : super(key: key);

  @override
  State<ProjectDetailsScreen> createState() => _ProjectDetailsScreenState();
}

class _ProjectDetailsScreenState extends State<ProjectDetailsScreen> {
  ProjectProvider? _projectProvider = null;
  VoteProvider? _voteProvider = null;
  ObjectiveProvider? _objectiveProvider = null;

  Project data = new Project();
  List<Vote> votes = [];
  List<Objective> objectives = [];
  Vote? userVote = null;
  bool isLoading = true;
  TextEditingController _searchController = TextEditingController();

  bool _isLiked = false;

  @override
  void initState() {
    super.initState();
    _projectProvider = context.read<ProjectProvider>();
    _voteProvider = context.read<VoteProvider>();
    _objectiveProvider = context.read<ObjectiveProvider>();
    loadData();
  }

  Future<Project> loadData() async {
    setState(() {
      isLoading = true;
    });
    Project tempData = await _projectProvider!.get(int.parse(this.widget.id));
    var tempVotes = await _voteProvider?.getList({"projectId": tempData.projectId, "userId": 2});
    setState(() {
      data = tempData;
      votes = tempVotes ?? [];
      userVote = votes.firstWhere((x) => x.userId == 2, orElse: () => new Vote());
      _isLiked = userVote?.positive ?? false;
      isLoading = false;
    });
    return tempData;
  }

  void vote(bool isPositive) async {
    if(userVote?.voteId != 0) {
      userVote?.positive = isPositive;
      await _voteProvider!.update(userVote?.voteId ?? -1, userVote);
    } else {
      userVote?.userId = 1;
      userVote!.positive = isPositive;
      userVote?.projectId = data.projectId ?? 0;
      var response = await _voteProvider!.insert(userVote);
      userVote?.voteId = response!.voteId;
    }

    setState(() {
      _isLiked = isPositive;
      userVote = userVote;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Padding(
        padding: EdgeInsets.all(20.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Expanded(
              child: SingleChildScrollView(
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Image.asset(
                      tProjectScreenImage,
                      height: 200,
                      width: double.infinity,
                      fit: BoxFit.cover,
                    ),
                    SizedBox(height: 20),
                    Align(
                      alignment: Alignment.bottomLeft,
                      child: Container(
                        decoration: BoxDecoration(
                          color: Colors.deepPurple,
                          borderRadius: BorderRadius.circular(5),
                        ),
                        padding:
                            EdgeInsets.symmetric(horizontal: 8, vertical: 4),
                        child: Container(
                          padding:
                              EdgeInsets.symmetric(horizontal: 8, vertical: 4),
                          child: Row(
                            mainAxisSize: MainAxisSize.min,
                            children: [
                              Icon(Icons.map, color: Colors.white, size: 18),
                              SizedBox(width: 4),
                              Text(
                                data.city,
                                style: TextStyle(
                                  color: Colors.white,
                                  fontWeight: FontWeight.bold,
                                  fontSize: 14,
                                ),
                              ),
                            ],
                          ),
                        ),
                      ),
                    ),
                    SizedBox(height: 10),
                    Align(
                      alignment: Alignment.bottomLeft,
                      child: Container(
                        decoration: BoxDecoration(
                          color: Colors.cyan,
                          borderRadius: BorderRadius.circular(5),
                        ),
                        padding:
                            EdgeInsets.symmetric(horizontal: 8, vertical: 4),
                        child: Container(
                          padding:
                              EdgeInsets.symmetric(horizontal: 8, vertical: 4),
                          child: Row(
                            mainAxisSize: MainAxisSize.min,
                            children: [
                              Icon(Icons.category,
                                  color: Colors.white, size: 18),
                              SizedBox(width: 4),
                              Text(
                                data.category,
                                style: TextStyle(
                                  color: Colors.white,
                                  fontWeight: FontWeight.bold,
                                  fontSize: 14,
                                ),
                              ),
                            ],
                          ),
                        ),
                      ),
                    ),
                    SizedBox(height: 20),
                    Text(
                      data.name + " (${data.status})",
                      style: TextStyle(
                        fontSize: 24,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                    SizedBox(height: 10),
                    Text(
                      data.description,
                      style: TextStyle(
                        fontSize: 16,
                      ),
                    ),
                    SizedBox(height: 20),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.center,
                      children: [
                        IconButton(
                          onPressed: () {
                            vote(true);
                          },
                          icon: Icon(
                            _isLiked
                                ? Icons.thumb_up_alt
                                : Icons.thumb_up_alt_outlined,
                            color: _isLiked && userVote?.voteId != 0 ? Colors.blue : null,
                          ),
                        ),
                        SizedBox(width: 10),
                        IconButton(
                          onPressed: () {
                            vote(false);
                          },
                          icon: Icon(
                            !_isLiked
                                ? Icons.thumb_down_alt
                                : Icons.thumb_down_alt_outlined,
                            color: !_isLiked && userVote?.voteId != 0 ? Colors.red : null,
                          ),
                        ),
                      ],
                    ),
                  ],
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }
}


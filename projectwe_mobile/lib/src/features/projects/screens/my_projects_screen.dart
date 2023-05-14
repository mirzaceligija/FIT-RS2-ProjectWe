import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/features/projects/controllers/project_provider.dart';
import 'package:projectwe_mobile/src/features/projects/models/project.dart';
import 'package:projectwe_mobile/src/features/projects/screens/project_details_screen.dart';
import 'package:projectwe_mobile/src/common_widgets/master_screen.dart';
import 'package:provider/provider.dart';
import '../../../constants/image_strings.dart';
import '../controllers/categories_provider.dart';
import '../controllers/cities_provider.dart';
import 'add_edit_project_screen.dart';

class MyProjectsScreen extends StatefulWidget {
  static const String routeName = "/my-project";

  MyProjectsScreen({Key? key}) : super(key: key);

  @override
  State<MyProjectsScreen> createState() => _MyProjectsScreenState();
}

class _MyProjectsScreenState extends State<MyProjectsScreen> {
  ProjectProvider? _projectProvider = null;
  CategoryProvider? _categoryProvider = null;
  CityProvider? _cityProvider = null;

  List<Project> data = [];
  bool isLoading = true;

  @override
  void initState() {
    super.initState();
    _projectProvider = context.read<ProjectProvider>();
    loadData();
  }

  Future loadData() async {
    setState(() {
      isLoading = true;
    });
    await loadProjects();
    setState(() {
      isLoading = false;
    });
  }

  Future loadProjects() async {
    var response =
        await _projectProvider?.getList({"userId": 3}); //Only user's projects
    setState(() {
      data = response!;
    });
  }

  @override
  Widget build(BuildContext context) {
    final size = MediaQuery.of(context).size;

    return MasterScreenWidget(
        child: Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
      _buildHeader(),
      _buildAddButton(),
      _buildProjectList(),
    ]));
  }

  Widget _buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        'My Projects',
        style: TextStyle(
            color: Colors.black, fontSize: 24, fontWeight: FontWeight.bold),
      ),
    );
  }

  Widget _buildAddButton() {
    return Container(
      width: double.infinity,
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: ElevatedButton(
          onPressed: () {
            Navigator.pushNamed(context,
                "${AddEditProjectScreen.routeName}/0");
          },
          child: const Text("ADD PROJECT")),
    );
  }

  Widget _buildProjectList() {
    return Expanded(
      child: ListView.builder(
          itemCount: data.length,
          itemBuilder: (context, index) {
            final project = data[index];
            return GestureDetector(
                onTap: () {
                  Navigator.pushNamed(
                    context,
                    "${ProjectDetailsScreen.routeName}/${project.projectId.toString()}",
                  );
                },
                child: Card(
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Image(
                        image: AssetImage(tProjectScreenImage),
                        width: double.infinity,
                        fit: BoxFit.cover,
                      ),
                      Padding(
                        padding: EdgeInsets.all(16.0),
                        child: Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            Text(
                              project.name + " (${project.status})",
                              style: TextStyle(
                                fontSize: 20.0,
                                fontWeight: FontWeight.bold,
                              ),
                            ),
                            SizedBox(height: 8.0),
                            Align(
                              alignment: Alignment.bottomLeft,
                              child: Container(
                                decoration: BoxDecoration(
                                  color: Colors.cyan,
                                  borderRadius: BorderRadius.circular(5),
                                ),
                                padding: EdgeInsets.symmetric(
                                    horizontal: 8, vertical: 4),
                                child: Container(
                                  padding: EdgeInsets.symmetric(
                                      horizontal: 8, vertical: 4),
                                  child: Row(
                                    mainAxisSize: MainAxisSize.min,
                                    children: [
                                      Icon(Icons.category,
                                          color: Colors.white, size: 18),
                                      SizedBox(width: 4),
                                      Text(
                                        project.category ?? "",
                                        style: TextStyle(
                                          color: Colors.white,
                                          fontWeight: FontWeight.bold,
                                          fontSize: 12,
                                        ),
                                      ),
                                    ],
                                  ),
                                ),
                              ),
                            ),
                            SizedBox(height: 8.0),
                            Align(
                              alignment: Alignment.bottomLeft,
                              child: Container(
                                decoration: BoxDecoration(
                                  color: Colors.deepPurple,
                                  borderRadius: BorderRadius.circular(5),
                                ),
                                padding: EdgeInsets.symmetric(
                                    horizontal: 8, vertical: 4),
                                child: Container(
                                  padding: EdgeInsets.symmetric(
                                      horizontal: 8, vertical: 4),
                                  child: Row(
                                    mainAxisSize: MainAxisSize.min,
                                    children: [
                                      Icon(Icons.map,
                                          color: Colors.white, size: 18),
                                      SizedBox(width: 4),
                                      Text(
                                        project.city ?? "",
                                        style: TextStyle(
                                          color: Colors.white,
                                          fontWeight: FontWeight.bold,
                                          fontSize: 12,
                                        ),
                                      ),
                                    ],
                                  ),
                                ),
                              ),
                            ),
                            SizedBox(height: 16.0),
                            Text(
                              project.description ?? "",
                              style: TextStyle(
                                  fontWeight: FontWeight.normal,
                                  fontSize: 13,
                                  color: Colors.black54),
                              maxLines: 2,
                              overflow: TextOverflow.ellipsis,
                            ),
                          ],
                        ),
                      ),
                    ],
                  ),
                  margin: EdgeInsets.symmetric(vertical: 8.0, horizontal: 16.0),
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(8.0),
                  ),
                ));
          }),
    );
  }
}

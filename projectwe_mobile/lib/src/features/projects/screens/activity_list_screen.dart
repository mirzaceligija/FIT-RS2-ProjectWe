import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/common_widgets/master_screen.dart';
import 'package:provider/provider.dart';

import '../controllers/activities_provider.dart';
import '../models/activity.dart';

class ActivityListScreen extends StatefulWidget {
  static const String routeName = "/activity_list";
  String projectId;

  ActivityListScreen(this.projectId, {Key? key}) : super(key: key);

  @override
  State<ActivityListScreen> createState() => _ActivityListScreenState();
}

class _ActivityListScreenState extends State<ActivityListScreen> {
  ActivityProvider? _activityProvider = null;

  List<Activity> data = [];
  bool isLoading = true;

  @override
  void initState() {
    super.initState();
    _activityProvider = context.read<ActivityProvider>();
    loadData();
  }

  Future loadData() async {
    setState(() {
      isLoading = true;
    });

    var response =
        await _activityProvider?.getList({"projectId": this.widget.projectId});
    setState(() {
      data = response!;
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: SingleChildScrollView(
          child: Container(
              child: Column(children: [
        _buildHeader(),
        Column(children: _buildActivityList()),
      ]))),
    );
  }

  Widget _buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        "Activities",
        style: TextStyle(
            color: Colors.black, fontSize: 24, fontWeight: FontWeight.bold),
      ),
    );
  }

  List<Widget> _buildActivityList() {
    if (data.length == 0) {
      return isLoading ? [Text("Loading...")] : [Text("No data found...")];
    }

    List<Widget> list = data
        .map((x) => Container(
            width: double.infinity,
            padding: EdgeInsets.all(20.0),
            margin: EdgeInsets.all(5.0),
            decoration: BoxDecoration(
              border: Border.all(
                color: Colors.grey,
                width: 1,
              ),
              borderRadius: BorderRadius.circular(10),
            ),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text(x.description ?? ""),
                Text("Locations: " + (x.locations ?? "")),
                Text("Direct Beneficiaries: " + (x.directBeneficiaries ?? "")),
                Text("Indirect Beneficiaries: " +
                    (x.indirectBeneficiaries ?? "")),
              ],
            )))
        .cast<Widget>()
        .toList();

    return list;
  }
}

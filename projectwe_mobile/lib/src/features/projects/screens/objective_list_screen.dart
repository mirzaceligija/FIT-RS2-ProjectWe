import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/common_widgets/master_screen.dart';
import 'package:provider/provider.dart';

import '../controllers/objectives_provider.dart';
import '../models/objective.dart';


class ObjectiveListScreen extends StatefulWidget {
  static const String routeName = "/objective_list";
  String projectId;

  ObjectiveListScreen(this.projectId, {Key? key}) : super(key: key);

  @override
  State<ObjectiveListScreen> createState() => _ObjectiveListScreenState();
}

class _ObjectiveListScreenState extends State<ObjectiveListScreen> {

  ObjectiveProvider? _objectiveProvider = null;

  List<Objective> data = [];
  bool isLoading = true;

  @override
  void initState() {
    super.initState();
    _objectiveProvider = context.read<ObjectiveProvider>();
    loadData();
  }

  Future loadData() async {
    setState(() {
      isLoading = true;
    });

    var response =
        await _objectiveProvider?.getList({"projectId": this.widget.projectId});
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
        Column(children: _buildObjectiveList()),
      ]))),
    );
  }

    Widget _buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        "Objectives",
        style: TextStyle(
            color: Colors.black, fontSize: 24, fontWeight: FontWeight.bold),
      ),
    );
  }

  List<Widget> _buildObjectiveList() {
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
                  Text(x.description ?? "")
              ],) 
            ))
        .cast<Widget>()
        .toList();

    return list;
  }
}
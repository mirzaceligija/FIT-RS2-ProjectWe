import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/common_widgets/master_screen.dart';
import 'package:projectwe_mobile/src/features/projects/models/output.dart';
import 'package:provider/provider.dart';

import '../controllers/outputs_provider.dart';

class OutputListScreen extends StatefulWidget {
  static const String routeName = "/output_list";
  String projectId;

  OutputListScreen(this.projectId, {Key? key}) : super(key: key);

  @override
  State<OutputListScreen> createState() => _OutputListScreenState();
}

class _OutputListScreenState extends State<OutputListScreen> {
  OutputProvider? _outputProvider = null;

  List<Output> data = [];
  bool isLoading = true;

  @override
  void initState() {
    super.initState();
    _outputProvider = context.read<OutputProvider>();
    loadData();
  }

  Future loadData() async {
    setState(() {
      isLoading = true;
    });

    var response =
        await _outputProvider?.getList({"projectId": this.widget.projectId});
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
        Column(children: _buildOutputList()),
      ]))),
    );
  }

    Widget _buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        "Outputs",
        style: TextStyle(
            color: Colors.black, fontSize: 24, fontWeight: FontWeight.bold),
      ),
    );
  }

  List<Widget> _buildOutputList() {
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
                  Text("Indicators: " + (x.indicators ?? "")),
                  Text("Means of verification: " + (x.meansOfVerification ?? "")),
              ],) 
            ))
        .cast<Widget>()
        .toList();

    return list;
  }
}

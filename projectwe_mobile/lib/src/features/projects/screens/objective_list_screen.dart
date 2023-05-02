import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/common_widgets/master_screen.dart';


class ObjectiveListScreen extends StatefulWidget {
  static const String routeName = "/objective_list";

  ObjectiveListScreen({Key? key}) : super(key: key);

  @override
  State<ObjectiveListScreen> createState() => _ObjectiveListScreenState();
}

class _ObjectiveListScreenState extends State<ObjectiveListScreen> {
  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Center(child: Text("Objective List works"),),
    );
  }
}
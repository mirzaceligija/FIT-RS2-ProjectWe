import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/common_widgets/master_screen.dart';


class ObjectiveDetailsScreen extends StatefulWidget {
  static const String routeName = "/objective_details";
  String id;

  ObjectiveDetailsScreen(this.id, {Key? key}) : super(key: key);

  @override
  State<ObjectiveDetailsScreen> createState() => _ObjectiveDetailsScreenState();
}

class _ObjectiveDetailsScreenState extends State<ObjectiveDetailsScreen> {
  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Center(child: Text("Objective Details works"),),
    );
  }
}
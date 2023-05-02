import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/common_widgets/master_screen.dart';


class OutputDetailsScreen extends StatefulWidget {
  static const String routeName = "/output_details";
  String id;

  OutputDetailsScreen(this.id, {Key? key}) : super(key: key);

  @override
  State<OutputDetailsScreen> createState() => _OutputDetailsScreenState();
}

class _OutputDetailsScreenState extends State<OutputDetailsScreen> {
  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Center(child: Text("Output Details works"),),
    );
  }
}
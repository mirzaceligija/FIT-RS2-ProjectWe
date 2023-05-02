import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/common_widgets/master_screen.dart';


class OutputListScreen extends StatefulWidget {
  static const String routeName = "/output_list";

  OutputListScreen({Key? key}) : super(key: key);

  @override
  State<OutputListScreen> createState() => _OutputListScreenState();
}

class _OutputListScreenState extends State<OutputListScreen> {
  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Center(child: Text("Output List works"),),
    );
  }
}
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/common_widgets/master_screen.dart';


class BudgetDetailsScreen extends StatefulWidget {
  static const String routeName = "/budget_details";
  String id;

  BudgetDetailsScreen(this.id, {Key? key}) : super(key: key);

  @override
  State<BudgetDetailsScreen> createState() => _BudgetDetailsScreenState();
}

class _BudgetDetailsScreenState extends State<BudgetDetailsScreen> {
  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Center(child: Text("Budget Details works"),),
    );
  }
}
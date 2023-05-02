import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/common_widgets/master_screen.dart';
import 'package:provider/provider.dart';

import '../controllers/budgets_provider.dart';
import '../models/budget.dart';

class BudgetListScreen extends StatefulWidget {
  static const String routeName = "/budget_list";
  String projectId;

  BudgetListScreen(this.projectId, {Key? key}) : super(key: key);

  @override
  State<BudgetListScreen> createState() => _BudgetListScreenState();
}

class _BudgetListScreenState extends State<BudgetListScreen> {
  BudgetProvider? _budgetProvider = null;

  List<Budget> data = [];
  bool isLoading = true;

  @override
  void initState() {
    super.initState();
    _budgetProvider = context.read<BudgetProvider>();
    loadData();
  }

  Future loadData() async {
    setState(() {
      isLoading = true;
    });

    var response =
        await _budgetProvider?.getList({"projectId": this.widget.projectId});
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
        Column(children: _buildBudgetList()),
      ]))),
    );
  }

  Widget _buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        "Budget",
        style: TextStyle(
            color: Colors.black, fontSize: 24, fontWeight: FontWeight.bold),
      ),
    );
  }

  List<Widget> _buildBudgetList() {
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
                Text("Cost Per Unit: " + (x.costPerUnit.toString())),
                Text("Number Of Units: " + (x.numberOfUnits.toString())),
                Text("Total Cost: " + (x.totalCost.toString())),
              ],
            )))
        .cast<Widget>()
        .toList();

    return list;
  }
}

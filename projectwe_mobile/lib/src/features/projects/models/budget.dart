import 'package:json_annotation/json_annotation.dart';

part 'budget.g.dart';

@JsonSerializable()
class Budget {
  int? budgetId;
  String? description;
  double? costPerUnit;
  int? numberOfUnits;
  double? totalCost;

  Budget({this.description = ""});

  factory Budget.fromJson(Map<String, dynamic> json) => _$BudgetFromJson(json);

  /// Connect the generated [_$BudgetToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$BudgetToJson(this);
}
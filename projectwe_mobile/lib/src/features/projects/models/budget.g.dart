// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'budget.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Budget _$BudgetFromJson(Map<String, dynamic> json) => Budget(
      description: json['description'] as String? ?? "",
    )
      ..budgetId = json['budgetId'] as int?
      ..costPerUnit = (json['costPerUnit'] as num?)?.toDouble()
      ..numberOfUnits = json['numberOfUnits'] as int?
      ..totalCost = (json['totalCost'] as num?)?.toDouble();

Map<String, dynamic> _$BudgetToJson(Budget instance) => <String, dynamic>{
      'budgetId': instance.budgetId,
      'description': instance.description,
      'costPerUnit': instance.costPerUnit,
      'numberOfUnits': instance.numberOfUnits,
      'totalCost': instance.totalCost,
    };

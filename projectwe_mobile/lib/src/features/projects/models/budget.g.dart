// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'budget.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Budget _$BudgetFromJson(Map<String, dynamic> json) => Budget(
      description: json['description'] as String? ?? "",
    )..budgetId = json['budgetId'] as int?;

Map<String, dynamic> _$BudgetToJson(Budget instance) => <String, dynamic>{
      'budgetId': instance.budgetId,
      'description': instance.description,
    };

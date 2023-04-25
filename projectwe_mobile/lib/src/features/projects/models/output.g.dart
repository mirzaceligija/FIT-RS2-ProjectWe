// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'output.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Output _$OutputFromJson(Map<String, dynamic> json) => Output(
      description: json['description'] as String? ?? "",
    )..outputId = json['outputId'] as int?;

Map<String, dynamic> _$OutputToJson(Output instance) => <String, dynamic>{
      'outputId': instance.outputId,
      'description': instance.description,
    };

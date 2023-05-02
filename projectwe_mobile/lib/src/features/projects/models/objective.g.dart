// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'objective.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Objective _$ObjectiveFromJson(Map<String, dynamic> json) => Objective(
      objectiveId: json['objectiveId'] as int? ?? 0,
      description: json['description'] as String? ?? "",
      projectId: json['projectId'] as int? ?? 0,
      userId: json['userId'] as int? ?? 0,
    );

Map<String, dynamic> _$ObjectiveToJson(Objective instance) => <String, dynamic>{
      'objectiveId': instance.objectiveId,
      'description': instance.description,
      'projectId': instance.projectId,
      'userId': instance.userId,
    };

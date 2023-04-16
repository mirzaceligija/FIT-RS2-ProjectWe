// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'project.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Project _$ProjectFromJson(Map<String, dynamic> json) => Project()
  ..projectId = json['projectId'] as int?
  ..name = json['name'] as String?
  ..description = json['description'] as String?;

Map<String, dynamic> _$ProjectToJson(Project instance) => <String, dynamic>{
      'projectId': instance.projectId,
      'name': instance.name,
      'description': instance.description,
    };

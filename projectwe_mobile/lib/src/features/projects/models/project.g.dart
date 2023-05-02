// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'project.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Project _$ProjectFromJson(Map<String, dynamic> json) => Project(
      projectId: json['projectId'] as int?,
      name: json['name'] as String? ?? "",
      description: json['description'] as String? ?? "",
      city: json['city'] as String? ?? "",
      cityId: json['cityId'] as int? ?? 0,
      category: json['category'] as String? ?? "",
      categoryId: json['categoryId'] as int? ?? 0,
      status: json['status'] as String? ?? "",
      statusId: json['statusId'] as int? ?? 0,
    );

Map<String, dynamic> _$ProjectToJson(Project instance) => <String, dynamic>{
      'projectId': instance.projectId,
      'name': instance.name,
      'description': instance.description,
      'city': instance.city,
      'cityId': instance.cityId,
      'category': instance.category,
      'categoryId': instance.categoryId,
      'status': instance.status,
      'statusId': instance.statusId,
    };

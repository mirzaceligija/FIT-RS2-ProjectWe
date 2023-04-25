// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'activity.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Activity _$ActivityFromJson(Map<String, dynamic> json) => Activity(
      description: json['description'] as String? ?? "",
    )..activityId = json['activityId'] as int?;

Map<String, dynamic> _$ActivityToJson(Activity instance) => <String, dynamic>{
      'activityId': instance.activityId,
      'description': instance.description,
    };

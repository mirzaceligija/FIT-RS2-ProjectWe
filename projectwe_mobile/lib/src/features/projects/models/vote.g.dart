// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'vote.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Vote _$VoteFromJson(Map<String, dynamic> json) => Vote(
      voteId: json['voteId'] as int? ?? 0,
      positive: json['positive'] as bool? ?? null,
      userId: json['userId'] as int? ?? 0,
      projectId: json['projectId'] as int? ?? 0,
    );

Map<String, dynamic> _$VoteToJson(Vote instance) => <String, dynamic>{
      'voteId': instance.voteId,
      'positive': instance.positive,
      'userId': instance.userId,
      'projectId': instance.projectId,
    };

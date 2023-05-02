
import 'package:json_annotation/json_annotation.dart';

part 'vote.g.dart';

@JsonSerializable()
class Vote {
  int? voteId;
  bool? positive;
  int userId;
  int projectId;

  Vote({
    this.voteId = 0,
    this.positive = null,
    this.userId = 0,
    this.projectId = 0,
  });

  factory Vote.fromJson(Map<String, dynamic> json) => _$VoteFromJson(json);

  /// Connect the generated [_$VoteToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$VoteToJson(this);
}
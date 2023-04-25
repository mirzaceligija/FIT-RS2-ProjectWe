import 'package:json_annotation/json_annotation.dart';

part 'activity.g.dart';

@JsonSerializable()
class Activity {
  int? activityId;
  String? description;

  Activity({this.description = ""});

  factory Activity.fromJson(Map<String, dynamic> json) => _$ActivityFromJson(json);

  /// Connect the generated [_$ActivityToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$ActivityToJson(this);
}
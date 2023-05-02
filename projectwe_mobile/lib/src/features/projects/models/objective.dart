
import 'package:json_annotation/json_annotation.dart';

part 'objective.g.dart';

@JsonSerializable()
class Objective {
  int? objectiveId;
  String? description;
  int? projectId;
  int? userId;

  Objective({this.objectiveId = 0, this.description = "", this.projectId = 0, this.userId = 0});

  factory Objective.fromJson(Map<String, dynamic> json) => _$ObjectiveFromJson(json);

  /// Connect the generated [_$ObjectiveToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$ObjectiveToJson(this);
}
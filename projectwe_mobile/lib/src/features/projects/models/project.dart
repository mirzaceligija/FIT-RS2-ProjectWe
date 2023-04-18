
import 'package:json_annotation/json_annotation.dart';

part 'project.g.dart';

@JsonSerializable()
class Project {
  int? projectId;
  String? name;
  String? description;
  String? city;
  String? category;

  Project(){}

  factory Project.fromJson(Map<String, dynamic> json) => _$ProjectFromJson(json);

  /// Connect the generated [_$ProjectToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$ProjectToJson(this);
}
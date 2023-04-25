import 'package:json_annotation/json_annotation.dart';

part 'project.g.dart';

@JsonSerializable()
class Project {
  int? projectId;
  String name;
  String description;
  String city;
  int cityId;
  String category;
  int categoryId;
  String status;
  int statusId;

  Project({
    this.projectId,
    this.name = "",
    this.description = "",
    this.city = "",
    this.cityId = 0,
    this.category = "",
    this.categoryId = 0,
    this.status = "",
    this.statusId = 0,
  });

  factory Project.fromJson(Map<String, dynamic> json) => _$ProjectFromJson(json);

  /// Connect the generated [_$ProjectToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$ProjectToJson(this);
}
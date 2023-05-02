import 'package:json_annotation/json_annotation.dart';

part 'output.g.dart';

@JsonSerializable()
class Output {
  int? outputId;
  String? description;

  Output({this.description = ""});

  factory Output.fromJson(Map<String, dynamic> json) => _$OutputFromJson(json);

  /// Connect the generated [_$OutputToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$OutputToJson(this);
}
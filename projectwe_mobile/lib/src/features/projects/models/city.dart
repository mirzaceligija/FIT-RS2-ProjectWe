
import 'package:json_annotation/json_annotation.dart';

part 'city.g.dart';

@JsonSerializable()
class City {
  int? cityId;
  String? name;

  City({this.name = ""});

  factory City.fromJson(Map<String, dynamic> json) => _$CityFromJson(json);

  /// Connect the generated [_$CityToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$CityToJson(this);
}
import 'dart:convert';
import 'dart:io';
import 'dart:async';
import 'package:http/http.dart';
import 'package:http/io_client.dart';
import 'package:flutter/foundation.dart';
import 'package:projectwe_mobile/src/features/core/providers/base_provider.dart';
import 'package:projectwe_mobile/src/features/projects/models/city.dart';

class CityProvider extends BaseProvider<City> {
  CityProvider() : super("Cities");

  @override
  City fromJson(data) {
    return City.fromJson(data);
  }
}
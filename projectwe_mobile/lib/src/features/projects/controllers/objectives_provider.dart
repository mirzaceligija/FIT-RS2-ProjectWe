import 'dart:convert';
import 'dart:io';
import 'dart:async';
import 'package:http/http.dart';
import 'package:http/io_client.dart';
import 'package:flutter/foundation.dart';
import 'package:projectwe_mobile/src/features/core/providers/base_provider.dart';
import 'package:projectwe_mobile/src/features/projects/models/objective.dart';

class ObjectiveProvider extends BaseProvider<Objective> {
  ObjectiveProvider() : super("Objectives");

  @override
  Objective fromJson(data) {
    return Objective.fromJson(data);
  }
}
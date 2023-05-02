import 'dart:convert';
import 'dart:io';
import 'dart:async';
import 'package:http/http.dart';
import 'package:http/io_client.dart';
import 'package:flutter/foundation.dart';
import 'package:projectwe_mobile/src/features/core/providers/base_provider.dart';
import 'package:projectwe_mobile/src/features/projects/models/activity.dart';

class ActivityProvider extends BaseProvider<Activity> {
  ActivityProvider() : super("Activities");

  @override
  Activity fromJson(data) {
    return Activity.fromJson(data);
  }
}
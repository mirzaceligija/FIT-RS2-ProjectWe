import 'dart:convert';
import 'dart:io';
import 'dart:async';
import 'package:http/http.dart';
import 'package:http/io_client.dart';
import 'package:flutter/foundation.dart';
import 'package:projectwe_mobile/src/features/core/providers/base_provider.dart';
import 'package:projectwe_mobile/src/features/projects/models/category.dart' as c;

class CategoryProvider extends BaseProvider<c.Category> {
  CategoryProvider() : super("Categories");

  @override
  c.Category fromJson(data) {
    return c.Category.fromJson(data);
  }
}
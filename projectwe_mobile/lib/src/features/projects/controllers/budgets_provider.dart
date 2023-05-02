import 'dart:convert';
import 'dart:io';
import 'dart:async';
import 'package:http/http.dart';
import 'package:http/io_client.dart';
import 'package:flutter/foundation.dart';
import 'package:projectwe_mobile/src/features/core/providers/base_provider.dart';
import 'package:projectwe_mobile/src/features/projects/models/budget.dart';

class BudgetProvider extends BaseProvider<Budget> {
  BudgetProvider() : super("Budgets");

  @override
  Budget fromJson(data) {
    return Budget.fromJson(data);
  }
}
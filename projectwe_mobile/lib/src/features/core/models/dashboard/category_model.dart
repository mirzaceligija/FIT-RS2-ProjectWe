
import 'package:flutter/cupertino.dart';

class DashboardCategoriesModel{
  final String title;
  final String heading;
  final String subHeading;
  final VoidCallback? onPress;

  DashboardCategoriesModel(this.title, this.heading,this.subHeading, this.onPress);

  static List<DashboardCategoriesModel> list = [
    DashboardCategoriesModel("JS", "Java Script", "10 lessons", null),
    DashboardCategoriesModel("F", "Flutter", "8 lessons", null),
    DashboardCategoriesModel("H", "HTML", "11 lessons", null),
    DashboardCategoriesModel("K", "Kotlin", "3 lessons", null),
    DashboardCategoriesModel("P", "Python", "20 lessons", null),
  ];
}
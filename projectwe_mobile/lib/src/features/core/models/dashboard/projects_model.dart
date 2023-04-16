
import 'package:flutter/cupertino.dart';
import 'package:projectwe_mobile/src/constants/image_strings.dart';

class DashboardProjectModel{
  final String title;
  final String heading;
  final String subHeading;
  final AssetImage imageURL;
  final VoidCallback? onPress;

  DashboardProjectModel(this.title, this.heading,this.subHeading, this.imageURL, this.onPress);

  static List<DashboardProjectModel> list = [
    DashboardProjectModel("Flutter Crash Course", "Java Script", "10 lessons", AssetImage(tTopProjectImage1), null),
    DashboardProjectModel("Javascript Crach Course", "Flutter", "8 lessons", AssetImage(tTopProjectImage1), null),
    DashboardProjectModel("AWS Certification Practice", "HTML", "11 lessons", AssetImage(tTopProjectImage1), null)
  ];
}
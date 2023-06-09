import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:projectwe_mobile/src/constants/colors.dart';
import 'package:projectwe_mobile/src/constants/sizes.dart';

class TElevatedButtonTheme {
  TElevatedButtonTheme._();

  static final lightElevatedButtonTheme = ElevatedButtonThemeData(
    style: ElevatedButton.styleFrom(
        shape: RoundedRectangleBorder(),
        foregroundColor: tWhiteColor,
        backgroundColor: tPrimaryColor,
        side: BorderSide(color: tPrimaryColor),
        padding: EdgeInsets.symmetric(vertical: tButtonHeight)),
  );
}
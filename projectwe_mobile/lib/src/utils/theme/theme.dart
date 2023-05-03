import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:projectwe_mobile/src/utils/theme/widget_themes/elevated_button_theme.dart';
import 'package:projectwe_mobile/src/utils/theme/widget_themes/outlined_button_theme.dart';
import 'package:projectwe_mobile/src/utils/theme/widget_themes/text_theme.dart';
import 'package:projectwe_mobile/src/utils/theme/widget_themes/text_theme_field.dart';

class TAppTheme {
  TAppTheme._();

  static ThemeData lightTheme = ThemeData(
    brightness: Brightness.light,
    elevatedButtonTheme: TElevatedButtonTheme.lightElevatedButtonTheme,
    outlinedButtonTheme: TOutlinedButtonTheme.lightOutlinedButtonTheme,
    textTheme: TTextTheme.lightTextTheme,
    iconTheme: IconThemeData(color: Colors.black),
    inputDecorationTheme: TTextFormFieldTheme.lightInputDecorationTheme,
    primarySwatch: MaterialColor(0xE6007DFF, <int, Color>{
      50: Color(0x1A007DFF),
      100: Color(0x33007DFF),
      200: Color(0x4D007DFF),
      300: Color(0x66007DFF),
      400: Color(0x80007DFF),
      500: Color(0xFF007DFF),
      600: Color(0x99007DFF),
      700: Color(0xB3007DFF),
      800: Color(0xCC007DFF),
      900: Color(0xE6007DFF),
    }),
  );
}

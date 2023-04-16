import 'dart:ui';

import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:projectwe_mobile/src/features/authentication/screens/splash_screen/splash_screen.dart';
import 'package:projectwe_mobile/src/features/core/screens/dashboard/widgets/dashboard.dart';
import 'package:projectwe_mobile/src/features/projects/controllers/project_provider.dart';
import 'package:projectwe_mobile/src/features/authentication/providers/user_provider.dart';
import 'package:projectwe_mobile/src/features/authentication/screens/on_boarding/on_boarding_screen.dart';
import 'package:projectwe_mobile/src/features/authentication/screens/welcome/welcome_screen.dart';
import 'package:projectwe_mobile/src/features/projects/screens/project_details_screen.dart';
import 'package:projectwe_mobile/src/features/projects/screens/project_list_screen.dart';
import 'package:projectwe_mobile/src/utils/theme/theme.dart';
import 'package:projectwe_mobile/src/utils/utils.dart';
import 'package:provider/provider.dart';

void main() => runApp(MultiProvider(
      providers: [
        ChangeNotifierProvider(create: (_) => ProjectProvider()),
        ChangeNotifierProvider(create: (_) => UserProvider()),
      ],
      child: const App(),
    ));

class App extends StatelessWidget {
  const App({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return GetMaterialApp(
      theme: TAppTheme.lightTheme,
      themeMode: ThemeMode.light,
      debugShowCheckedModeBanner: true,
      defaultTransition: Transition.leftToRightWithFade,
      transitionDuration: const Duration(milliseconds: 500),
      onGenerateRoute: ((settings) {
        if (settings.name == Dashboard.routeName) {
          return MaterialPageRoute(builder: ((context) => Dashboard()));
        } else if (settings.name == ProjectListScreen.routeName) {
          return MaterialPageRoute(builder: ((context) => ProjectListScreen()));
        } else if (settings.name == OnBoardingScreen.routeName) {
          return MaterialPageRoute(builder: ((context) => OnBoardingScreen()));
        } else if (settings.name == WelcomeScreen.routeName) {
          return MaterialPageRoute(builder: ((context) => WelcomeScreen()));
        }

        var uri = Uri.parse(settings.name!);
        if (uri.pathSegments.length == 2 &&
            "/${uri.pathSegments.first}" == ProjectDetailsScreen.routeName) {
          var id = uri.pathSegments[1];
          return MaterialPageRoute(
              builder: (context) => ProjectDetailsScreen(id));
        }
      }),
      home: SplashScreen(),
    );
  }
}
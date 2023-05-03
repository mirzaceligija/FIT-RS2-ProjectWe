import 'dart:ui';

import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:projectwe_mobile/src/features/authentication/screens/account/account_details_screen.dart';
import 'package:projectwe_mobile/src/features/authentication/screens/splash_screen/splash_screen.dart';
import 'package:projectwe_mobile/src/features/core/providers/navigation_provider.dart';
import 'package:projectwe_mobile/src/features/core/screens/dashboard/widgets/dashboard.dart';
import 'package:projectwe_mobile/src/features/projects/controllers/activities_provider.dart';
import 'package:projectwe_mobile/src/features/projects/controllers/budgets_provider.dart';
import 'package:projectwe_mobile/src/features/projects/controllers/categories_provider.dart';
import 'package:projectwe_mobile/src/features/projects/controllers/cities_provider.dart';
import 'package:projectwe_mobile/src/features/projects/controllers/objectives_provider.dart';
import 'package:projectwe_mobile/src/features/projects/controllers/outputs_provider.dart';
import 'package:projectwe_mobile/src/features/projects/controllers/project_provider.dart';
import 'package:projectwe_mobile/src/features/authentication/providers/user_provider.dart';
import 'package:projectwe_mobile/src/features/authentication/screens/on_boarding/on_boarding_screen.dart';
import 'package:projectwe_mobile/src/features/authentication/screens/welcome/welcome_screen.dart';
import 'package:projectwe_mobile/src/features/projects/controllers/votes_provider.dart';
import 'package:projectwe_mobile/src/features/projects/screens/activity_details_screen.dart';
import 'package:projectwe_mobile/src/features/projects/screens/activity_list_screen.dart';
import 'package:projectwe_mobile/src/features/projects/screens/budget_details.dart';
import 'package:projectwe_mobile/src/features/projects/screens/budget_list_screen.dart';
import 'package:projectwe_mobile/src/features/projects/screens/objective_details_screen.dart';
import 'package:projectwe_mobile/src/features/projects/screens/objective_list_screen.dart';
import 'package:projectwe_mobile/src/features/projects/screens/output_details_screen.dart';
import 'package:projectwe_mobile/src/features/projects/screens/output_list_screen.dart';
import 'package:projectwe_mobile/src/features/projects/screens/project_details_screen.dart';
import 'package:projectwe_mobile/src/features/projects/screens/project_list_screen.dart';
import 'package:projectwe_mobile/src/utils/theme/theme.dart';
import 'package:projectwe_mobile/src/utils/utils.dart';
import 'package:provider/provider.dart';

void main() => runApp(MultiProvider(
      providers: [
        ChangeNotifierProvider(create: (_) => AppNavigation()),
        ChangeNotifierProvider(create: (_) => ProjectProvider()),
        ChangeNotifierProvider(create: (_) => CityProvider()),
        ChangeNotifierProvider(create: (_) => CategoryProvider()),
        ChangeNotifierProvider(create: (_) => VoteProvider()),
        ChangeNotifierProvider(create: (_) => ObjectiveProvider()),
        ChangeNotifierProvider(create: (_) => OutputProvider()),
        ChangeNotifierProvider(create: (_) => ActivityProvider()),
        ChangeNotifierProvider(create: (_) => BudgetProvider()),
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
          return MaterialPageRoute(builder: ((context) => ProjectListScreen(settings.arguments as bool? ?? false)));
        } else if (settings.name == OnBoardingScreen.routeName) {
          return MaterialPageRoute(builder: ((context) => OnBoardingScreen()));
        } else if (settings.name == WelcomeScreen.routeName) {
          return MaterialPageRoute(builder: ((context) => WelcomeScreen()));
        } else if (settings.name == AccountDetailsScreen.routeName) {
          return MaterialPageRoute(builder: ((context) => AccountDetailsScreen()));
        } else if (settings.name == ObjectiveListScreen.routeName) {
          return MaterialPageRoute(builder: ((context) => WelcomeScreen()));
        } else if (settings.name == BudgetListScreen.routeName) {
          return MaterialPageRoute(builder: ((context) => WelcomeScreen()));
        } else if (settings.name == ActivityListScreen.routeName) {
          return MaterialPageRoute(builder: ((context) => WelcomeScreen()));
        }

        var uri = Uri.parse(settings.name!);
        if (uri.pathSegments.length == 2 &&
            "/${uri.pathSegments.first}" == ProjectDetailsScreen.routeName) {
          var id = uri.pathSegments[1];
          return MaterialPageRoute(
              builder: (context) => ProjectDetailsScreen(id));
        }  else if (uri.pathSegments.length == 2 &&
            "/${uri.pathSegments.first}" == OutputListScreen.routeName) {
          var id = uri.pathSegments[1];
          return MaterialPageRoute(
              builder: (context) => OutputListScreen(id));
        } else if (uri.pathSegments.length == 2 &&
            "/${uri.pathSegments.first}" == OutputDetailsScreen.routeName) {
          var id = uri.pathSegments[1];
          return MaterialPageRoute(
              builder: (context) => OutputDetailsScreen(id));
        }  else if (uri.pathSegments.length == 2 &&
            "/${uri.pathSegments.first}" == ObjectiveListScreen.routeName) {
          var id = uri.pathSegments[1];
          return MaterialPageRoute(
              builder: (context) => ObjectiveListScreen(id));
        } else if (uri.pathSegments.length == 2 &&
            "/${uri.pathSegments.first}" == ObjectiveDetailsScreen.routeName) {
          var id = uri.pathSegments[1];
          return MaterialPageRoute(
              builder: (context) => ObjectiveDetailsScreen(id));
        }  else if (uri.pathSegments.length == 2 &&
            "/${uri.pathSegments.first}" == ActivityListScreen.routeName) {
          var id = uri.pathSegments[1];
          return MaterialPageRoute(
              builder: (context) => ActivityListScreen(id));
        } else if (uri.pathSegments.length == 2 &&
            "/${uri.pathSegments.first}" == ActivityDetailsScreen.routeName) {
          var id = uri.pathSegments[1];
          return MaterialPageRoute(
              builder: (context) => ActivityDetailsScreen(id));
        }  else if (uri.pathSegments.length == 2 &&
            "/${uri.pathSegments.first}" == BudgetListScreen.routeName) {
          var id = uri.pathSegments[1];
          return MaterialPageRoute(
              builder: (context) => BudgetListScreen(id));
        } else if (uri.pathSegments.length == 2 &&
            "/${uri.pathSegments.first}" == BudgetDetailsScreen.routeName) {
          var id = uri.pathSegments[1];
          return MaterialPageRoute(
              builder: (context) => BudgetDetailsScreen(id));
        }
      }),
      home: SplashScreen(),
    );
  }
}
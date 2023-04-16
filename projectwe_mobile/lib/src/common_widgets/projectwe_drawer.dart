import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:projectwe_mobile/main.dart';
import 'package:projectwe_mobile/src/features/authentication/screens/splash_screen/splash_screen.dart';
import 'package:projectwe_mobile/src/features/authentication/screens/welcome/welcome_screen.dart';
import 'package:projectwe_mobile/src/features/core/screens/dashboard/widgets/dashboard.dart';
import 'package:projectwe_mobile/src/features/projects/screens/project_list_screen.dart';
import 'package:provider/provider.dart';


class projectWeDrawer extends StatelessWidget {
  projectWeDrawer({Key? key}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    return Drawer(
      child: ListView(
        children: [
          ListTile(
            title: Text('Dashboard'),
            onTap: () {
               Navigator.popAndPushNamed(context, Dashboard.routeName);
            },
          ),
          ListTile(
            title: Text('Projects'),
            onTap: () {
               Navigator.popAndPushNamed(context, ProjectListScreen.routeName);
            },
          ),
          ListTile(
            title: Text('My Projects'),
            onTap: () {
               Navigator.popAndPushNamed(context, ProjectListScreen.routeName);
            },
          ),
          ListTile(
            title: Text('Account'),
            onTap: () {
               Navigator.popAndPushNamed(context, ProjectListScreen.routeName);
            },
          ),
          ListTile(
            title: Text('Sign Out'),
            onTap: () {
               Navigator.pushAndRemoveUntil(
                context,
                MaterialPageRoute(builder: (context) => WelcomeScreen()),
                (Route<dynamic> route) => false,
              );
            },
          ),
        ],
      ),
    );
  }
}
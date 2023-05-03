import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/constants/colors.dart';
import 'package:projectwe_mobile/src/features/authentication/screens/account/account_details_screen.dart';
import 'package:projectwe_mobile/src/features/authentication/screens/welcome/welcome_screen.dart';
import 'package:projectwe_mobile/src/features/core/screens/dashboard/widgets/dashboard.dart';
import 'package:projectwe_mobile/src/features/projects/screens/project_list_screen.dart';

class projectWeDrawer extends StatelessWidget {
  projectWeDrawer({Key? key}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    return Drawer(
      backgroundColor: tWhiteColor,
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
              Navigator.popAndPushNamed(context, ProjectListScreen.routeName,
                  arguments: false);
            },
          ),
          ListTile(
            title: Text('My Projects'),
            onTap: () {
              Navigator.popAndPushNamed(context, ProjectListScreen.routeName,
                  arguments: true);
            },
          ),
          ListTile(
            title: Text('Account'),
            onTap: () {
              Navigator.popAndPushNamed(
                  context, AccountDetailsScreen.routeName);
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
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:projectwe_mobile/src/constants/colors.dart';
import 'package:projectwe_mobile/src/constants/text_strings.dart';
import 'package:projectwe_mobile/src/features/authentication/screens/account/account_details_screen.dart';
import 'package:projectwe_mobile/src/features/core/screens/dashboard/widgets/dashboard.dart';
import 'package:projectwe_mobile/src/features/projects/screens/project_list_screen.dart';
import 'package:projectwe_mobile/src/common_widgets/projectwe_drawer.dart';
import 'package:provider/provider.dart';

import '../constants/image_strings.dart';
import '../features/core/providers/navigation_provider.dart';

class MasterScreenWidget extends StatefulWidget {
  Widget? child;
  MasterScreenWidget({this.child, Key? key}) : super(key: key);

  @override
  State<MasterScreenWidget> createState() => _MasterScreenWidgetState();
}

class _MasterScreenWidgetState extends State<MasterScreenWidget> {
  int currentIndex = 0;
  late AppNavigation _appNavigation;

  @override
  void initState() {
    super.initState();
    _appNavigation = context.read<AppNavigation>();
  }

  void _onItemTapped(int index) {
    _appNavigation.setIndex(index);

    setState(() {
      currentIndex = index;
    });
    if (currentIndex == 0) {
      Navigator.pushNamed(context, Dashboard.routeName);
    } else if (currentIndex == 1) {
      Navigator.pushNamed(context, ProjectListScreen.routeName,
          arguments: false);
    } else if (currentIndex == 2) {
      Navigator.pushNamed(context, ProjectListScreen.routeName,
          arguments: true);
    } else if (currentIndex == 3) {
      Navigator.pushNamed(context, AccountDetailsScreen.routeName);
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        iconTheme: IconThemeData(color: tSecondaryColor),
        elevation: 0,
        backgroundColor: Colors.transparent,
        title: Image.asset(
          tLogo,
          height: 20,
        ),
        centerTitle: true,
      ),
      drawer: projectWeDrawer(),
      body: SafeArea(
        child: widget.child!,
      ),
      bottomNavigationBar: BottomNavigationBar(
        selectedLabelStyle: const TextStyle(color: Colors.black54),
        unselectedItemColor: Colors.black87,
        unselectedLabelStyle: const TextStyle(color: Colors.black45),
        items: const <BottomNavigationBarItem>[
          BottomNavigationBarItem(
            icon: Icon(Icons.home),
            label: 'Dashboard',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.assignment_outlined),
            label: 'Projects',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.auto_awesome),
            label: 'My Projects',
          ),
          BottomNavigationBarItem(
              icon: Icon(Icons.account_box_rounded), label: 'Account'),
        ],
        selectedItemColor: Theme.of(context).primaryColor,
        selectedIconTheme: IconThemeData(color: tPrimaryColor),
        currentIndex: _appNavigation.currentIndex,
        onTap: _onItemTapped,
      ),
    );
  }
}

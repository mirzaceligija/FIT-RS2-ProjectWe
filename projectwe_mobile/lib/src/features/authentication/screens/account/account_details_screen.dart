import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/common_widgets/master_screen.dart';
import 'package:provider/provider.dart';

import '../../../../constants/sizes.dart';
import '../../../../constants/text_strings.dart';
import '../../../../utils/utils.dart';
import '../../models/user.dart';
import '../../providers/user_provider.dart';

class AccountDetailsScreen extends StatefulWidget {
  static const String routeName = "/account_details";

  AccountDetailsScreen({Key? key}) : super(key: key);

  @override
  State<AccountDetailsScreen> createState() => _AccountDetailsScreenState();
}

class _AccountDetailsScreenState extends State<AccountDetailsScreen> {
  TextEditingController _firstNameController = TextEditingController();
  TextEditingController _lastNameController = TextEditingController();
  TextEditingController _emailController = TextEditingController();
  TextEditingController _passwordController = TextEditingController();
  TextEditingController _confirmPasswordController = TextEditingController();

  UserProvider? _userProvider = null;
  bool isLoading = true;
  int? userId = Authorization.id;
  User data = new User();

  @override
  void initState() {
    super.initState();
    _userProvider = context.read<UserProvider>();
    loadData();
  }

  Future<User> loadData() async {
    setState(() {
      isLoading = true;
    });
    User tempData = await _userProvider!.get(userId ?? 0);
    setState(() {
      data = tempData;
      isLoading = false;
      _firstNameController.text = data.firstName ?? "";
      _lastNameController.text = data.lastName ?? "";
      _emailController.text = data.email ?? "";
    });
    return tempData;
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
        child: SingleChildScrollView(
            child: Padding(
                padding: EdgeInsets.all(20.0),
                child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text("Username: " + (data.username ?? "")),
                      const SizedBox(height: 20.00),
                      Container(
                          padding: const EdgeInsets.symmetric(
                              vertical: tFormHeight - 10),
                          child: Form(
                              child: Column(
                                  crossAxisAlignment: CrossAxisAlignment.start,
                                  children: [
                                TextFormField(
                                  controller: _firstNameController,
                                  decoration: const InputDecoration(
                                      label: Text(tFirstName),
                                      prefixIcon:
                                          Icon(Icons.person_outline_rounded)),
                                ),
                                const SizedBox(height: tFormHeight - 20),
                                TextFormField(
                                  controller: _lastNameController,
                                  decoration: const InputDecoration(
                                      label: Text(tLastName),
                                      prefixIcon:
                                          Icon(Icons.person_outline_rounded)),
                                ),
                                const SizedBox(height: tFormHeight - 20),
                                TextFormField(
                                  controller: _emailController,
                                  decoration: const InputDecoration(
                                      label: Text(tEmail),
                                      prefixIcon: Icon(Icons.email_outlined)),
                                ),
                                const SizedBox(height: tFormHeight - 20),
                                TextFormField(
                                  obscureText: true,
                                  enableSuggestions: false,
                                  autocorrect: false,
                                  controller: _passwordController,
                                  decoration: const InputDecoration(
                                      label: Text(tPassword),
                                      prefixIcon: Icon(Icons.fingerprint)),
                                ),
                                const SizedBox(height: tFormHeight - 20),
                                TextFormField(
                                  obscureText: true,
                                  enableSuggestions: false,
                                  autocorrect: false,
                                  controller: _confirmPasswordController,
                                  decoration: const InputDecoration(
                                      label: Text(tConfirmPassword),
                                      prefixIcon: Icon(Icons.fingerprint)),
                                ),
                                const SizedBox(height: tFormHeight - 10),
                                SizedBox(
                                  width: double.infinity,
                                  child: ElevatedButton(
                                    onPressed: () async {
                                      try {
                                        data.firstName =
                                            _firstNameController.text;
                                        data.lastName =
                                            _lastNameController.text;
                                        data.email = _emailController.text;
                                        data.password =
                                            _passwordController.text;
                                        data.confirmPassword =
                                            _passwordController.text;

                                        await _userProvider!
                                            .update(userId ?? 0, data);
                                      } catch (e) {
                                        showDialog(
                                            context: context,
                                            builder: (BuildContext context) =>
                                                AlertDialog(
                                                  title: Text("Error"),
                                                  content: Text(e.toString()),
                                                  actions: [
                                                    TextButton(
                                                      child: Text("Ok"),
                                                      onPressed: () =>
                                                          Navigator.pop(
                                                              context),
                                                    )
                                                  ],
                                                ));
                                      }
                                    },
                                    child: Text(tUpdate.toUpperCase()),
                                  ),
                                )
                              ]))),
                    ]))));
  }
}

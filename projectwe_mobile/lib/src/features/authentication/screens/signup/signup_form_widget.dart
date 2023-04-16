import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:get/get_core/src/get_main.dart';
import 'package:projectwe_mobile/src/constants/sizes.dart';
import 'package:projectwe_mobile/src/constants/text_strings.dart';
import 'package:projectwe_mobile/src/features/authentication/models/user.dart';
import 'package:projectwe_mobile/src/features/authentication/providers/user_provider.dart';
import 'package:projectwe_mobile/src/features/authentication/screens/signin/signin_screen.dart';
import 'package:provider/provider.dart';

class SignUpFormWidget extends StatelessWidget {
  TextEditingController _usernameController = TextEditingController();
  TextEditingController _passwordController = TextEditingController();
  TextEditingController _confirmPasswordController = TextEditingController();
  TextEditingController _firstNameController = TextEditingController();
  TextEditingController _lastNameController = TextEditingController();
  TextEditingController _emailController = TextEditingController();

  late UserProvider _userProvider;

  @override
  Widget build(BuildContext context) {
    _userProvider = Provider.of<UserProvider>(context, listen: false);

    return Container(
      padding: const EdgeInsets.symmetric(vertical: tFormHeight - 10),
      child: Form(
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            TextFormField(
              controller: _firstNameController,
              decoration: const InputDecoration(
                  label: Text(tFirstName),
                  prefixIcon: Icon(Icons.person_outline_rounded)),
            ),
            const SizedBox(height: tFormHeight - 20),
            TextFormField(
              controller: _lastNameController,
              decoration: const InputDecoration(
                  label: Text(tLastName),
                  prefixIcon: Icon(Icons.person_outline_rounded)),
            ),
            const SizedBox(height: tFormHeight - 20),
            TextFormField(
              controller: _usernameController,
              decoration: const InputDecoration(
                  label: Text(tUsername),
                  prefixIcon: Icon(Icons.text_format)),
            ),
            const SizedBox(height: tFormHeight - 20),
            TextFormField(
              controller: _emailController,
              decoration: const InputDecoration(
                  label: Text(tEmail), prefixIcon: Icon(Icons.email_outlined)),
            ),
            const SizedBox(height: tFormHeight - 20),
            TextFormField(
              obscureText: true,
              enableSuggestions: false,
              autocorrect: false,
              controller: _passwordController,
              decoration: const InputDecoration(
                  label: Text(tPassword), prefixIcon: Icon(Icons.fingerprint)),
            ),
            const SizedBox(height: tFormHeight - 20),
            TextFormField(
              obscureText: true,
              enableSuggestions: false,
              autocorrect: false,
              controller: _confirmPasswordController,
              decoration: const InputDecoration(
                  label: Text(tConfirmPassword), prefixIcon: Icon(Icons.fingerprint)),
            ),
            const SizedBox(height: tFormHeight - 10),
            SizedBox(
              width: double.infinity,
              child: ElevatedButton(
                onPressed: () async {
                  try {
                    var userToCreate = new User();
                    userToCreate.firstName = _firstNameController.text;
                    userToCreate.lastName = _lastNameController.text;
                    userToCreate.username = _usernameController.text;
                    userToCreate.email = _emailController.text;
                    userToCreate.password= _passwordController.text;
                    userToCreate.confirmPassword = _confirmPasswordController.text;

                    await _userProvider.signUp(userToCreate);
                    Get.to(() => SignInScreen());
                  } catch (e) {
                    showDialog(
                        context: context,
                        builder: (BuildContext context) => AlertDialog(
                              title: Text("Error"),
                              content: Text(e.toString()),
                              actions: [
                                TextButton(
                                  child: Text("Ok"),
                                  onPressed: () => Navigator.pop(context),
                                )
                              ],
                            ));
                  }
                },
                child: Text(tSignUp.toUpperCase()),
              ),
            )
          ],
        ),
      ),
    );
  }
}
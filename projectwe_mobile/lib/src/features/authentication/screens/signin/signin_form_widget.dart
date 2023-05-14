import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:projectwe_mobile/src/constants/sizes.dart';
import 'package:projectwe_mobile/src/constants/text_strings.dart';
import 'package:projectwe_mobile/src/features/authentication/providers/user_provider.dart';
import 'package:projectwe_mobile/src/features/authentication/screens/on_boarding/on_boarding_screen.dart';
import 'package:projectwe_mobile/src/utils/utils.dart';
import 'package:provider/provider.dart';

class SignInFormWidget extends StatelessWidget {
  TextEditingController _usernameController = TextEditingController();
  TextEditingController _passwordController = TextEditingController();

  late UserProvider _userProvider;
  late GlobalKey<FormState> _formKey;

  @override
  Widget build(BuildContext context) {
    _userProvider = Provider.of<UserProvider>(context, listen: false);
    _formKey = new GlobalKey<FormState>();

    _usernameController.text = "manager";
    _passwordController.text = "test";

    return Container(
      padding: const EdgeInsets.symmetric(vertical: tFormHeight - 10),
      child: Form(
        key: _formKey,
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            TextFormField(
              controller: _usernameController,
              decoration: const InputDecoration(
                  label: Text(tUsername),
                  border: OutlineInputBorder(),
                  prefixIcon: Icon(Icons.text_format)),
              validator: (value) => _validateRequired(value, 'Username'),
            ),
            const SizedBox(height: tFormHeight - 20),
            TextFormField(
              controller: _passwordController,
              autocorrect: false,
              enableSuggestions: false,
              obscureText:
                  false, //this part should be true, but it was causing page refresh on focus
              decoration: const InputDecoration(
                  border: OutlineInputBorder(),
                  label: Text(tPassword),
                  prefixIcon: Icon(Icons.fingerprint)),
              validator: (value) => _validateRequired(value, 'Password'),
            ),
            const SizedBox(height: tFormHeight - 20),
            SizedBox(
              width: double.infinity,
              child: ElevatedButton(
                onPressed: () async {
                  try {
                    if (_formKey.currentState!.validate()) {
                      Authorization.username = _usernameController.text;
                      Authorization.password = _passwordController.text;

                      var user = await _userProvider.signIn({
                        "userName": Authorization.username,
                        "password": Authorization.password
                      });
                      Authorization.token = user?.token;
                      Authorization.id = user?.id;
                      Get.to(() => OnBoardingScreen());
                    }
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
                child: Text(tSignIn.toUpperCase()),
              ),
            )
          ],
        ),
      ),
    );
  }

  String? _validateRequired(String? value, String fieldName) {
    if (value == null || value.isEmpty) {
      return 'Please enter $fieldName';
    }
    return null;
  }
}

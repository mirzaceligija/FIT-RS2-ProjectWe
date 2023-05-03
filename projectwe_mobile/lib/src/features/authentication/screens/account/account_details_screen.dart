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
  TextEditingController _userNameController = TextEditingController();
  TextEditingController _firstNameController = TextEditingController();
  TextEditingController _lastNameController = TextEditingController();
  TextEditingController _emailController = TextEditingController();
  TextEditingController _passwordController = TextEditingController();
  TextEditingController _confirmPasswordController = TextEditingController();

  UserProvider? _userProvider = null;
  GlobalKey<FormState> _formKey = GlobalKey<FormState>();

  bool _readOnly = true;
  bool isLoading = true;
  int? userId = Authorization.id;
  User data = User();

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
      _userNameController.text = data.username ?? "";
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
            child: Container(
                child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
          _buildHeader(),
          _buildForm(),
        ]))));
  }

  Widget _buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        "Account Details",
        style: TextStyle(
            color: Colors.black, fontSize: 24, fontWeight: FontWeight.bold),
      ),
    );
  }

  Widget _buildForm() {
    return Container(
        padding: const EdgeInsets.symmetric(
            vertical: tFormHeight - 10, horizontal: 20.00),
        child: Form(
            key: _formKey,
            child:
                Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
              TextFormField(
                enabled: false,
                controller: _userNameController,
                readOnly: true,
                decoration: const InputDecoration(
                    label: Text(tUsername + " (readonly)"),
                    prefixIcon: Icon(Icons.person_outline_rounded)),
              ),
              const SizedBox(height: tFormHeight - 10),
              TextFormField(
                enabled: !_readOnly,
                readOnly: _readOnly,
                controller: _firstNameController,
                decoration: const InputDecoration(
                    label: Text(tFirstName),
                    prefixIcon: Icon(Icons.person_outline_rounded)),
                validator: (value) => _validateRequired(value, 'First Name'),
              ),
              const SizedBox(height: tFormHeight - 10),
              TextFormField(
                enabled: !_readOnly,
                readOnly: _readOnly,
                controller: _lastNameController,
                decoration: const InputDecoration(
                    label: Text(tLastName),
                    prefixIcon: Icon(Icons.person_outline_rounded)),
                validator: (value) => _validateRequired(value, 'Last Name'),
              ),
              const SizedBox(height: tFormHeight - 10),
              TextFormField(
                enabled: !_readOnly,
                readOnly: _readOnly,
                controller: _emailController,
                decoration: const InputDecoration(
                    label: Text(tEmail),
                    prefixIcon: Icon(Icons.email_outlined)),
                validator: (value) => _validateRequired(value, 'Email'),
              ),
              const SizedBox(height: tFormHeight - 10),
              TextFormField(
                enabled: !_readOnly,
                readOnly: _readOnly,
                obscureText: true,
                enableSuggestions: false,
                autocorrect: false,
                controller: _passwordController,
                decoration: const InputDecoration(
                    label: Text(tPassword),
                    prefixIcon: Icon(Icons.fingerprint)),
                validator: (value) => _validateRequired(value, 'Password'),
              ),
              const SizedBox(height: tFormHeight - 10),
              TextFormField(
                enabled: !_readOnly,
                readOnly: _readOnly,
                obscureText: true,
                enableSuggestions: false,
                autocorrect: false,
                controller: _confirmPasswordController,
                decoration: const InputDecoration(
                    label: Text(tConfirmPassword),
                    prefixIcon: Icon(Icons.fingerprint)),
                validator: (value) =>
                    _validateRequired(value, 'Confirm Password'),
              ),
              const SizedBox(height: tFormHeight - 10),
              SizedBox(
                width: double.infinity,
                child: ElevatedButton(
                  onPressed: () async {
                    if (_readOnly) {
                      setState(() {
                        _readOnly = !_readOnly;
                      });
                      return;
                    }

                    try {
                      if (_formKey.currentState!.validate()) {
                        data.firstName = _firstNameController.text;
                        data.lastName = _lastNameController.text;
                        data.email = _emailController.text;
                        data.password = _passwordController.text;
                        data.confirmPassword = _passwordController.text;

                        await _userProvider!.update(userId ?? 0, data);

                        setState(() {
                          _readOnly = true;
                          _passwordController.text = "";
                          _confirmPasswordController.text = "";
                        });
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
                  child: Text(
                      _readOnly ? tEdit.toUpperCase() : tUpdate.toUpperCase()),
                ),
              )
            ])));
  }

  String? _validateRequired(String? value, String fieldName) {
    if (value == null || value.isEmpty) {
      return 'Please enter $fieldName';
    }
    return null;
  }
}

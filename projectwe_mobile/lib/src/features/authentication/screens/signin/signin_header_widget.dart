import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/constants/image_strings.dart';
import 'package:projectwe_mobile/src/constants/text_strings.dart';

class SignInHeaderWidget extends StatelessWidget {
  const SignInHeaderWidget({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    final size = MediaQuery.of(context).size;

    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Image(
            image: const AssetImage(tWelcomeScreenImage),
            height: size.height * 0.4),
        Text(tSignInTitle, style: Theme.of(context).textTheme.headline1),
        Text(tSignInSubtitle, style: Theme.of(context).textTheme.bodyText1),
      ],
    );
  }
}
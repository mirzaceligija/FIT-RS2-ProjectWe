import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:get/get_core/src/get_main.dart';
import 'package:projectwe_mobile/src/constants/colors.dart';
import 'package:projectwe_mobile/src/constants/image_strings.dart';
import 'package:projectwe_mobile/src/constants/sizes.dart';
import 'package:projectwe_mobile/src/constants/text_strings.dart';
import 'package:projectwe_mobile/src/features/authentication/screens/signin/signin_screen.dart';
import 'package:projectwe_mobile/src/features/authentication/screens/signup/signup_screen.dart';
import 'package:projectwe_mobile/src/common_widgets/fade_in_animation/animation_design.dart';
import 'package:projectwe_mobile/src/common_widgets/fade_in_animation/fade_in_animation_model.dart';
import 'package:projectwe_mobile/src/common_widgets/fade_in_animation/splash_screen_controller.dart';

class WelcomeScreen extends StatelessWidget {
  static const String routeName = "/welcome";

  const WelcomeScreen({Key? key}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    final controller = Get.put(FadeInAnimationController());
    controller.startAnimation();
    var height = MediaQuery.of(context).size.height;
    return Scaffold(
        body: Stack(
      children: [
        TFadeInAnimation(
          durationInMs: 1200,
          animate: TAnimatePosition(
              bottomAfter: 0,
              bottomBefore: -100,
              leftBefore: 0,
              leftAfter: 0,
              rightBefore: 0,
              rightAfter: 0,
              topAfter: 0,
              topBefore: 0),
          child: Container(
            padding: EdgeInsets.all(tDefaultSize),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.spaceEvenly,
              children: [
                Image(
                  image: AssetImage(tWelcomeScreenImage),
                  height: height * 0.4,
                ),
                Column(
                  children: [
                    Text(tWelcomeTitle,
                        style: Theme.of(context).textTheme.headline3),
                    Text(
                      tWelcomeSubTitle,
                      style: Theme.of(context).textTheme.bodyText1,
                      textAlign: TextAlign.center,
                    ),
                  ],
                ),
                Row(
                  children: [
                    Expanded(
                        child: OutlinedButton(
                            onPressed: () => Get.to(() => SignInScreen()),
                            child: Text(tSignIn.toUpperCase()))),
                    SizedBox(width: 10.0),
                    Expanded(
                        child: ElevatedButton(
                            onPressed: ()  => Get.to(() => SignUpScreen()),
                            child: Text(tSignUp.toUpperCase()))),
                  ],
                )
              ],
            ),
          ),
        ),
      ],
    ));
  }
}
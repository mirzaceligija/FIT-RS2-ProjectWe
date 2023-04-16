import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:projectwe_mobile/src/constants/colors.dart';
import 'package:projectwe_mobile/src/constants/image_strings.dart';
import 'package:projectwe_mobile/src/constants/sizes.dart';
import 'package:projectwe_mobile/src/constants/text_strings.dart';
import 'package:projectwe_mobile/src/common_widgets/fade_in_animation/animation_design.dart';
import 'package:projectwe_mobile/src/common_widgets/fade_in_animation/fade_in_animation_model.dart';
import 'package:projectwe_mobile/src/common_widgets/fade_in_animation/splash_screen_controller.dart';

class SplashScreen extends StatelessWidget {
  SplashScreen({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    final controller = Get.put(FadeInAnimationController());
    controller.startSplashAnimation();

    return Scaffold(
      body: Stack(
        children: [
          TFadeInAnimation(
            durationInMs: 2000,
            animate: TAnimatePosition(
                topAfter: 80,
                topBefore: 80,
                leftAfter: tDefaultSize,
                leftBefore: -80),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text(
                  tAppName,
                  style: Theme.of(context).textTheme.headline3,
                ),
                Text(tAppTagline, style: Theme.of(context).textTheme.headline4)
              ],
            ),
          ),
          TFadeInAnimation(
              durationInMs: 2400,
              animate: TAnimatePosition(bottomAfter: 200, bottomBefore: 0),
              child: Image(
                image: AssetImage(tSplashScreenImage),
                height: 300,
              )),
          TFadeInAnimation(
            durationInMs: 2400,
            animate: TAnimatePosition(
                bottomAfter: 60,
                bottomBefore: 0,
                rightAfter: tDefaultSize,
                rightBefore: tDefaultSize),
            child: Container(
              width: tSplashScreenContainerSize,
              height: tSplashScreenContainerSize,
              decoration: BoxDecoration(
                  borderRadius: BorderRadius.circular(100),
                  color: tPrimaryColor),
            ),
          ),
        ],
      ),
    );
  }
}
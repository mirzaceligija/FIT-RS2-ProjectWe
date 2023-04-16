import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/constants/colors.dart';
import 'package:projectwe_mobile/src/constants/image_strings.dart';
import 'package:projectwe_mobile/src/constants/sizes.dart';
import 'package:projectwe_mobile/src/constants/text_strings.dart';

class DashboardBanners extends StatelessWidget {
  const DashboardBanners({
    Key? key,
    required this.textTheme,
  }) : super(key: key);

  final TextTheme textTheme;

  @override
  Widget build(BuildContext context) {
    return Row(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Expanded(
          child: Container(
            decoration: BoxDecoration(
                borderRadius: BorderRadius.circular(10),
                color: tCardBgColor),
            padding: const EdgeInsets.symmetric(
                horizontal: 10, vertical: 20),
            child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Row(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Flexible(
                          child: Image(
                              image: AssetImage(tBookmarkIcon))),
                      Flexible(
                          child: Image(
                              image: AssetImage(tBannerImage1))),
                    ],
                  ),
                  const SizedBox(
                    height: 25,
                  ),
                  Text(
                    tDashboardBannerTitle1,
                    style: textTheme.headline4,
                    maxLines: 2,
                    overflow: TextOverflow.ellipsis,
                  ),
                  Text(
                    tDashboardBannerSubtitle,
                    style: textTheme.bodyText2,
                    maxLines: 1,
                    overflow: TextOverflow.ellipsis,
                  )
                ]),
          ),
        ),
        const SizedBox(width: tDashboardPadding),
        Expanded(
            child: Column(
          children: [
            Container(
              decoration: BoxDecoration(
                  borderRadius: BorderRadius.circular(10),
                  color: tCardBgColor),
              padding: const EdgeInsets.symmetric(
                  horizontal: 10, vertical: 20),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Row(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Flexible(
                          child: Image(
                              image: AssetImage(tBookmarkIcon))),
                      Flexible(
                          child: Image(
                              image: AssetImage(tBannerImage1))),
                    ],
                  ),
                  Text(
                    tDashboardBannerTitle1,
                    style: textTheme.headline4,
                    overflow: TextOverflow.ellipsis,
                  ),
                  Text(
                    tDashboardBannerSubtitle,
                    style: textTheme.bodyText2,
                    overflow: TextOverflow.ellipsis,
                  )
                ],
              ),
            ),
            SizedBox(
                width: double.infinity,
                child: OutlinedButton(
                    onPressed: () {}, child: Text(tDashboardButton)))
          ],
        ))
      ],
    );
  }
}
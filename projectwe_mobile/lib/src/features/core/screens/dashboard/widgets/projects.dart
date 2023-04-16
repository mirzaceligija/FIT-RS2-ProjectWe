import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/constants/colors.dart';
import 'package:projectwe_mobile/src/constants/image_strings.dart';
import 'package:projectwe_mobile/src/constants/sizes.dart';
import 'package:projectwe_mobile/src/features/core/models/dashboard/projects_model.dart';

class DashboardTopProjects extends StatelessWidget {
  const DashboardTopProjects({
    Key? key,
    required this.textTheme,
  }) : super(key: key);

  final TextTheme textTheme;

  @override
  Widget build(BuildContext context) {
    final list = DashboardProjectModel.list;
    return SizedBox(
      height: 200,
      child: ListView.builder(
          itemCount: list.length,
          shrinkWrap: true,
          scrollDirection: Axis.horizontal,
          itemBuilder: ((context, index) => GestureDetector(
                onTap: list[index].onPress,
                child: SizedBox(
                  width: 320,
                  height: 200,
                  child: Padding(
                    padding: EdgeInsets.only(right: 10, top: 5),
                    child: Container(
                      decoration: BoxDecoration(
                          borderRadius: BorderRadius.circular(10),
                          color: tCardBgColor),
                      padding: const EdgeInsets.all(10),
                      child: Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            Row(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Flexible(
                                    child: Text(
                                  list[index].title,
                                  style: textTheme.headline4,
                                  maxLines: 2,
                                  overflow: TextOverflow.ellipsis,
                                )),
                                Flexible(
                                    child: Image(
                                  image: list[index].imageURL,
                                  height: 110,
                                ))
                              ],
                            ),
                            Row(
                              children: [
                                ElevatedButton(
                                    style: ElevatedButton.styleFrom(
                                        shape: const CircleBorder()),
                                    onPressed: () {},
                                    child: const Icon(Icons.play_arrow)),
                                const SizedBox(width: tDashboardPadding),
                                Column(
                                  crossAxisAlignment: CrossAxisAlignment.start,
                                  children: [
                                    Text(
                                      list[index].heading,
                                      style: textTheme.headline4,
                                      overflow: TextOverflow.ellipsis,
                                    ),
                                    Text(
                                      list[index].subHeading,
                                      style: textTheme.bodyText2,
                                      overflow: TextOverflow.ellipsis,
                                    ),
                                  ],
                                )
                              ],
                            )
                          ]),
                    ),
                  ),
                ),
              ))),
    );
  }
}
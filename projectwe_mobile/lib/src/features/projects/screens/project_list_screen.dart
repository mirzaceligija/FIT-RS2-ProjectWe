import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/features/projects/controllers/project_provider.dart';
import 'package:projectwe_mobile/src/features/projects/models/project.dart';
import 'package:projectwe_mobile/src/features/projects/screens/project_details_screen.dart';
import 'package:projectwe_mobile/src/common_widgets/master_screen.dart';
import 'package:provider/provider.dart';
import '../../../constants/image_strings.dart';
import '../controllers/categories_provider.dart';
import '../controllers/cities_provider.dart';
import '../models/category.dart';
import '../models/city.dart';

class ProjectListScreen extends StatefulWidget {
  static const String routeName = "/project";

  const ProjectListScreen({Key? key}) : super(key: key);

  @override
  State<ProjectListScreen> createState() => _ProjectListScreenState();
}

class _ProjectListScreenState extends State<ProjectListScreen> {
  ProjectProvider? _projectProvider = null;
  CategoryProvider? _categoryProvider = null;
  CityProvider? _cityProvider = null;

  List<Project> data = [];
  List<Category> _categories = [];
  List<City> _cities = [];
  Category? _selectedCategory;
  City? _selectedCity;
  String? _searchTerm;
  bool isLoading = true;

  TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _projectProvider = context.read<ProjectProvider>();
    _categoryProvider = context.read<CategoryProvider>();
    _cityProvider = context.read<CityProvider>();
    loadData();
  }

  Future loadData() async {
    setState(() {
      isLoading = true;
    });
    await loadProjects(null, null, null);
    await loadCities();
    await loadCategories();
    setState(() {
      isLoading = false;
    });
  }

  Future loadProjects(int? categoryId, int? cityId, String? name) async {
    var response =
        await _projectProvider?.getList({"statusId": 3, "cityId": cityId, "categoryId": categoryId, "name": name}); //Only active projects
    setState(() {
      data = response!;
    });
  }

  Future loadCities() async {
    var response = await _cityProvider!.getList(null);
    setState(() {
      _cities = response;
    });
  }

  Future loadCategories() async {
    var response = await _categoryProvider!.getList(null);
    setState(() {
      _categories = response;
    });
  }

  @override
  Widget build(BuildContext context) {
    final size = MediaQuery.of(context).size;

    return MasterScreenWidget(
        child: SingleChildScrollView(
      child: Container(
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            _buildHeader(),
            _buildProjectSearch(),
            _buildProjectFilter(),
            Container(
              padding: EdgeInsets.fromLTRB(20.0, 20.0, 20.0, 50.0),
              height: 450,
              child: GridView(
                gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
                    crossAxisCount: 1,
                    childAspectRatio: 9 / 14,
                    crossAxisSpacing: 20,
                    mainAxisSpacing: 20),
                scrollDirection: Axis.vertical,
                children: _buildProjectCardList(),
              ),
            )
          ],
        ),
      ),
    ));
  }

  Widget _buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        "Projects",
        style: TextStyle(
            color: Colors.black, fontSize: 24, fontWeight: FontWeight.bold),
      ),
    );
  }

  Widget _buildProjectSearch() {
    return Row(
      children: [
        Expanded(
          child: Container(
            padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
            child: TextField(
              controller: _searchController,
              onSubmitted: (value) async {
                setState(() {
                  isLoading = true;
                  _searchTerm = value;
                });
                await loadProjects(_selectedCategory!.categoryId, _selectedCity!.cityId, _searchTerm);
                setState(() {
                  isLoading = false;
                });
              },
              decoration: InputDecoration(
                  hintText: "Search",
                  prefixIcon: Icon(Icons.search),
                  border: OutlineInputBorder(
                      borderRadius: BorderRadius.circular(10),
                      borderSide: BorderSide(color: Colors.grey))),
            ),
          ),
        ),
      ],
    );
  }

  Widget _buildProjectFilter() {
    return Padding(
        padding: EdgeInsets.all(20.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            DropdownButton<Category>(
              isExpanded: true,
              value: _selectedCategory,
              hint: Text('Select category'),
              onChanged: (Category? newValue) {
                setState(() {
                  _selectedCategory = newValue;
                });
              },
              items: _categories
                  .map<DropdownMenuItem<Category>>((Category category) {
                return DropdownMenuItem<Category>(
                  value: category,
                  child: Text(category.name),
                );
              }).toList(),
            ),
            SizedBox(height: 16.0),
            DropdownButton<City>(
              isExpanded: true,
              value: _selectedCity,
              hint: Text('Select city'),
              onChanged: (City? newValue) {
                setState(() {
                  _selectedCity = newValue;
                });
              },
              items: _cities.map<DropdownMenuItem<City>>((City city) {
                return DropdownMenuItem<City>(
                  value: city,
                  child: Text(city.name ?? ""),
                );
              }).toList(),
            ),
            SizedBox(height: 16.0),
            ElevatedButton(
              onPressed: () async {
                if (_selectedCategory != null && _selectedCity != null) {
                  await loadProjects(_selectedCategory!.categoryId, _selectedCity!.cityId, _searchTerm);
                }
              },
              child: Text('Filter'),
            )
          ],
        ));
  }

  List<Widget> _buildProjectCardList() {
    if (data.length == 0) {
      return isLoading ? [Text("Loading...")] : [Text("No data found...")];
    }

    List<Widget> list = data
        .map((x) => Container(
              padding: EdgeInsets.all(20.0),
              decoration: BoxDecoration(
                border: Border.all(
                  color: Colors.grey,
                  width: 1,
                ),
                borderRadius: BorderRadius.circular(10),
              ),
              child: Expanded(
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Image(
                      image: AssetImage(tProjectScreenImage),
                      width: double.infinity,
                      fit: BoxFit.cover,
                    ),
                    SizedBox(height: 20),
                    Text(
                      x.name ?? "",
                      style: TextStyle(
                        fontWeight: FontWeight.bold,
                        fontSize: 18,
                      ),
                      maxLines: 2,
                      overflow: TextOverflow.ellipsis,
                    ),
                    SizedBox(height: 10),
                    Align(
                      alignment: Alignment.bottomLeft,
                      child: Container(
                        decoration: BoxDecoration(
                          color: Colors.deepPurple,
                          borderRadius: BorderRadius.circular(5),
                        ),
                        padding:
                            EdgeInsets.symmetric(horizontal: 8, vertical: 4),
                        child: Container(
                          padding:
                              EdgeInsets.symmetric(horizontal: 8, vertical: 4),
                          child: Row(
                            mainAxisSize: MainAxisSize.min,
                            children: [
                              Icon(Icons.map, color: Colors.white, size: 18),
                              SizedBox(width: 4),
                              Text(
                                x.city ?? "",
                                style: TextStyle(
                                  color: Colors.white,
                                  fontWeight: FontWeight.bold,
                                  fontSize: 14,
                                ),
                              ),
                            ],
                          ),
                        ),
                      ),
                    ),
                    SizedBox(height: 10),
                    Align(
                      alignment: Alignment.bottomLeft,
                      child: Container(
                        decoration: BoxDecoration(
                          color: Colors.cyan,
                          borderRadius: BorderRadius.circular(5),
                        ),
                        padding:
                            EdgeInsets.symmetric(horizontal: 8, vertical: 4),
                        child: Container(
                          padding:
                              EdgeInsets.symmetric(horizontal: 8, vertical: 4),
                          child: Row(
                            mainAxisSize: MainAxisSize.min,
                            children: [
                              Icon(Icons.category,
                                  color: Colors.white, size: 18),
                              SizedBox(width: 4),
                              Text(
                                x.category ?? "",
                                style: TextStyle(
                                  color: Colors.white,
                                  fontWeight: FontWeight.bold,
                                  fontSize: 14,
                                ),
                              ),
                            ],
                          ),
                        ),
                      ),
                    ),
                    SizedBox(height: 10),
                    Text(
                      x.description ?? "",
                      style: TextStyle(
                          fontSize: 14,
                          color: Colors.black54,
                          fontWeight: FontWeight.w300),
                      maxLines: 2,
                      overflow: TextOverflow.ellipsis,
                    ),
                    Expanded(
                      child: Container(),
                    ),
                    Container(
                      width: double.infinity,
                      child: ElevatedButton(
                          onPressed: () {
                            Navigator.pushNamed(context,
                                "${ProjectDetailsScreen.routeName}/${x.projectId.toString()}");
                          },
                          child: const Text("View Details")),
                    ),
                  ],
                ),
              ),
            ))
        .cast<Widget>()
        .toList();

    return list;
  }
}

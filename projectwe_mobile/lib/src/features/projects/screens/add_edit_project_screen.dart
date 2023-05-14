import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwe_mobile/src/common_widgets/master_screen.dart';
import 'package:provider/provider.dart';

import '../../../constants/sizes.dart';
import '../../../constants/text_strings.dart';
import '../controllers/categories_provider.dart';
import '../controllers/cities_provider.dart';
import '../controllers/project_provider.dart';
import '../models/category.dart';
import '../models/city.dart';
import '../models/project.dart';

class AddEditProjectScreen extends StatefulWidget {
  static const String routeName = "/new-project";
  String id = "0";
  AddEditProjectScreen(this.id, {Key? key}) : super(key: key);

  @override
  State<AddEditProjectScreen> createState() => _AddEditScreenState();
}

class _AddEditScreenState extends State<AddEditProjectScreen> {
  ProjectProvider? _projectProvider = null;

  CategoryProvider? _categoryProvider = null;
  CityProvider? _cityProvider = null;

  TextEditingController _nameController = TextEditingController();
  TextEditingController _descriptionController = TextEditingController();

  GlobalKey<FormState> _formKey = GlobalKey<FormState>();
  Project data = Project();
  List<Category> _categories = [];
  List<City> _cities = [];
  Category? _selectedCategory;
  City? _selectedCity;

  bool _readOnly = true;
  bool isLoading = true;

  //Objectives
  List<String> objectives = [];
  List<Widget> _formFields = [];

  @override
  void initState() {
    super.initState();
    _projectProvider = context.read<ProjectProvider>();
    _categoryProvider = context.read<CategoryProvider>();
    _cityProvider = context.read<CityProvider>();
    _readOnly = int.parse(widget.id) > 0;
    _formFields = [_buildFormFields()];

    loadData();
  }

  Future loadData() async {
    setState(() {
      isLoading = true;
    });
    await loadCities();
    await loadCategories();
    setState(() {
      isLoading = false;
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
    return MasterScreenWidget(
      child: SingleChildScrollView(
        child: Container(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              _buildHeader(),
              _buildProjectForm(),
              _buildSubHeader("Objectives"),
              ..._formFields, // use the spread operator to add the widgets in _formFields
              _buildSubmitButton()
            ],
          ),
        ),
      ),
    );
  }

  Widget _buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        int.parse(widget.id) == 0 ? 'Add Project' : 'Edit Project',
        style: TextStyle(
            color: Colors.black, fontSize: 24, fontWeight: FontWeight.bold),
      ),
    );
  }
  
    Widget _buildSubHeader(String value) {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        value,
        style: TextStyle(
            color: Colors.black, fontSize: 18, fontWeight: FontWeight.bold),
      ),
    );
  }

    Widget _buildSubmitButton() {
      return Container(
                padding: const EdgeInsets.symmetric(
                    vertical: tFormHeight - 10, horizontal: 10.00),
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
                        data.name = _nameController.text;
                        data.description = _descriptionController.text;
                        data.categoryId = _selectedCategory!.categoryId ?? 0;
                        data.cityId = _selectedCity!.cityId ?? 0;
                        data.statusId = 1;

                        await _projectProvider!.insert(data);

                        setState(() {
                          _readOnly = true;
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
                      _readOnly ? tUpdate.toUpperCase() : tAdd.toUpperCase()),
                ),
              );
    }

  Widget _buildFormFields() {
    return Container(
      padding: const EdgeInsets.symmetric(
          vertical: tFormHeight - 10, horizontal: 20.00),
      child: Column(
        children: [
          //...
          ..._buildObjectivesFields(), // use the spread operator to add the widgets in _buildObjectivesFields
          const SizedBox(height: tFormHeight - 10),
          Align(
            alignment: Alignment.centerRight,
            child: ElevatedButton(
              onPressed: _addObjective,
              child: Text("Add Objective"),
            ),
          ),
          const SizedBox(height: tFormHeight - 10),
          //...
        ],
      ),
    );
  }

  List<Widget> _buildObjectivesFields() {
    return objectives
        .map((objective) => Padding(
              padding: const EdgeInsets.symmetric(vertical: tFormHeight - 10),
              child: Row(
                children: [
                  Expanded(
                    child: TextFormField(
                      initialValue: objective,
                      onChanged: (value) {
                        objectives[objectives.indexOf(objective)] = value;
                      },
                      decoration: const InputDecoration(
                        labelText: "Objective",
                        hintText: "Enter objective",
                      ),
                    ),
                  ),
                  IconButton(
                    onPressed: () {
                      setState(() {
                        objectives.remove(objective);
                        _formFields = [
                          _buildFormFields()
                        ]; // update the _formFields list
                      });
                    },
                    icon: const Icon(Icons.delete),
                  ),
                ],
              ),
            ))
        .toList();
  }

  void _addObjective() {
    setState(() {
      objectives.add("");
      _formFields = [_buildFormFields()]; // update the _formFields list
    });
  }

  Widget _buildProjectForm() {
    return Container(
        padding: const EdgeInsets.symmetric(
            vertical: tFormHeight - 10, horizontal: 20.00),
        child: Column(children: [
          Form(
              key: _formKey,
              child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    TextFormField(
                      enabled: !_readOnly,
                      readOnly: _readOnly,
                      controller: _nameController,
                      decoration: const InputDecoration(
                          label: Text(tName),
                          prefixIcon: Icon(Icons.person_outline_rounded)),
                      validator: (value) => _validateRequired(value, 'Name'),
                    ),
                    const SizedBox(height: tFormHeight - 10),
                    TextFormField(
                      enabled: !_readOnly,
                      readOnly: _readOnly,
                      controller: _descriptionController,
                      decoration: const InputDecoration(
                          label: Text(tDescription),
                          prefixIcon: Icon(Icons.person_outline_rounded)),
                      validator: (value) =>
                          _validateRequired(value, 'Description'),
                    ),
                    const SizedBox(height: tFormHeight - 10),
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
                    const SizedBox(height: tFormHeight - 10),
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
                    const SizedBox(height: tFormHeight - 10),
                  ]))
        ]));
  }

  String? _validateRequired(String? value, String fieldName) {
    if (value == null || value.isEmpty) {
      return 'Please enter $fieldName';
    }
    return null;
  }
}

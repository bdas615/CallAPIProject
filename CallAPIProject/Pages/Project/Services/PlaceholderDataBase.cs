using Microsoft.AspNetCore.Components;
using Project_Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using static CallAPIProject.Pages.Project.Services.PlaceholderDataBase;

namespace CallAPIProject.Pages.Project.Services
{
    public class PlaceholderDataBase : ComponentBase
    {


        public string SearchText = "";
        [Inject]
        public IJsonPlaceholder PlaceholderService { get; set; }

        ArrayList TT;

        public int SortInt { get; set; }

        public IEnumerable<Interface> InterfaceVariable { get; set; }

        public List<Interface> w = new List<Interface>();

        public List<Interface> y = new List<Interface>();

        public List<Interface> aa = new List<Interface>();

        public List<Interface> bb = new List<Interface>();
        public string search { get; set; }
        public string BodyVar { get; set; }

        public IEnumerable<Interface>[] arr1;

        public List<Interface>[] arr2;

        int[] marks = new int[] { 99, 98, 92, 97, 95 };

        public Interface[] t;

        public Interface[] tu;

        public string id { get; set; }

        public string title { get; set; }

        public int len { get; set; }
        public string body { get; set; }

        public string AllData { get; set; }

        public string c { get; set; }

        public int Len { get; set; }

        public int Len2 { get; set; }
        
        private string selectedSort;
        
       /* public string SelectedSort
        {
            get { return selectedSort; }
            set
            {
                selectedSort = value;
                selectedSortDictionary[selectedSort]();
            }
        }*/

      /*  Dictionary<string, Action> selectedSortDictionary;*/
        protected override async Task OnInitializedAsync()
        {
            InterfaceVariable = (await PlaceholderService.GetPlaceholderData()).ToList();

            ButtonClick();
            
        }
        public void ButtonClick()
        {

            if (search != null)
            {
                w.Clear();
                foreach (var x in InterfaceVariable)
                {
                    body = x.Body.ToString();
                    body = body.Replace("\n", " ");
                    /*  char bodyy = char.Parse(body);*/
                    id = x.Id.ToString();
                    title = x.Title.ToString();

                    if (body==search)
                    {
                        /*BodyVar = (string)BodyVar.Where(s => s.Equals(search));*/
                        w.Add(x);
                    }

                    if (title == search)
                    {
                        
                        w.Add(x);
                    }

                    if (id == search)
                    {
                        w.Add(x);
                    }
                } 
            }
            else 
            {
                foreach (var x in InterfaceVariable)
                {
                    w.Add(x);
                }
            }
        }

       /* public void Sort(Comparison<Interface> comparison) 
        {
            foreach (var x in InterfaceVariable) 
            {
                int[] result = x.Id.ToString().Select(o => Convert.ToInt32(o)).ToArray();
               *//* Array.Sort<int>((result, new Comparison<int>((i1, i2) => i1.CompareTo(i2)));*//*
                Array.Sort(result, delegate (int m, int n) { return m - n;});

                if (x.Id == x.Id) 
                {
                    w.Add(x);
                }
                
                
            }
        }*/
        public void SortingFunction()
        {
            w.Clear();
            foreach (var x in InterfaceVariable)
            {
                int[] result = x.Id.ToString().Select(o => Convert.ToInt32(o)).ToArray();
                /* Array.Sort<int>((result, new Comparison<int>((i1, i2) => i1.CompareTo(i2)));*/
                Array.Sort(result, delegate (int m, int n) { return m - n; });

               

                if (x.Id == x.Id)
                {
                    w.Add(x);
                }


            /*    foreach (var x in InterfaceVariable)
            {
                id = x.Id.ToString();

                if (x.Id == x.Id)
                {
                    w.Add(x);
                }

                selectedSortDictionary = new Dictionary<string, Action>
                {
                    ["old"] = () => w = (List<Interface>)w.OrderByDescending(s => s.Id),
                    ["new"] = () => w = (List<Interface>)w.OrderBy(s => s.Id),
                };
                w.Add(x);*/
            }

        /*
        t = w.ToArray();

        Len = t.Length;

        for (int i = Len; i >= 0; i--)
        {
            foreach (var x in InterfaceVariable)
            {
                y.Add(x);
                x.Id = SortInt;
                SortInt.Sort();
            }

        }*/

    }




    }



}



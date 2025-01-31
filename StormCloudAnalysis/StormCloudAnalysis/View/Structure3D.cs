﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;
using System.Windows.Media;
using System.Windows.Data;
using System.Windows;
using System.Windows.Threading;
using System.ComponentModel;
using Rhino.Geometry;
using StructureEngine.Model;
using StormCloud.ViewModel;
using HelixToolkit.Wpf;

namespace StormCloud.View
{
    public class Structure3D: BaseVM
    {
        //List<Line> _elements = GlobalGeoData.Linework;
        public Point3D NodeToHelixPoint(Node n)
        {
            return new Point3D(n.X, n.Y, n.Z);
        }

        public void Draw(ComputedStructure structure)
        {
            var modelGroup = new Model3DGroup();
            var meshBuilderTension = new MeshBuilder(false, false);
            var meshBuilderCompression = new MeshBuilder(false, false);

            foreach (ComputedMember m in structure.Members)
            {
                if (m.MaxAxialForce < 0)
                {
                    meshBuilderCompression.AddCylinder(NodeToHelixPoint(m.NodeI), NodeToHelixPoint(m.NodeJ), m.ReqDim, 20); // resolution hard-coded, section parameter = radius
                }

                else
                {
                    meshBuilderTension.AddCylinder(NodeToHelixPoint(m.NodeI), NodeToHelixPoint(m.NodeJ), m.ReqDim, 20); 
                }
            }

            
            // Create meshes from the builder (and freeze it)
            var meshTension = meshBuilderTension.ToMesh(true);
            var meshCompression = meshBuilderCompression.ToMesh(true);
            
            // Create materials
            var CMaterialCompression = MaterialHelper.CreateMaterial(Colors.Red);
            var CMaterialTension = MaterialHelper.CreateMaterial(Colors.Blue);

            // Add to modelGroup
            modelGroup.Children.Add(new GeometryModel3D { Geometry = meshTension, Material = CMaterialTension, BackMaterial = CMaterialTension });
            modelGroup.Children.Add(new GeometryModel3D { Geometry = meshCompression, Material = CMaterialCompression, BackMaterial = CMaterialCompression });

            // Assign modelGroup to Model to draw
            this.Model = modelGroup;

        }

        private ComputedStructure _comp;

        public ComputedStructure Comp
        {
            get
            {
                return _comp;
            }
            set
            {
                if (CheckPropertyChanged<ComputedStructure>("Comp", ref _comp, ref value))
                {
                }
            }
        }

        private Model3D _model;

        public Model3D Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (CheckPropertyChanged<Model3D>("Model", ref _model, ref value))
                {
                }
            }
        }

        //public List<Line> Elements
        //{
        //    get { return _elements; }
        //    set { _elements = GlobalGeoData.Linework; OnPropertyChanged("Elements"); }
        //}
        //public void UpdateModel()
        //{

        //}
        
        //protected virtual void OnPropertyChanged(string propertyName)
        //{
        //    var handler = PropertyChanged;
        //    if (handler != null) 
        //    {
        //        handler(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}


        
        //public event PropertyChangedEventHandler PropertyChanged;
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace AjaxDemo.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class StudentContext : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new StudentContext object using the connection string found in the 'StudentContext' section of the application configuration file.
        /// </summary>
        public StudentContext() : base("name=StudentContext", "StudentContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new StudentContext object.
        /// </summary>
        public StudentContext(string connectionString) : base(connectionString, "StudentContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new StudentContext object.
        /// </summary>
        public StudentContext(EntityConnection connection) : base(connection, "StudentContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Student> Students
        {
            get
            {
                if ((_Students == null))
                {
                    _Students = base.CreateObjectSet<Student>("Students");
                }
                return _Students;
            }
        }
        private ObjectSet<Student> _Students;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Students EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToStudents(Student student)
        {
            base.AddObject("Students", student);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EMSModel", Name="Student")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Student : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Student object.
        /// </summary>
        /// <param name="studentID">Initial value of the StudentID property.</param>
        /// <param name="studentName">Initial value of the StudentName property.</param>
        /// <param name="totalMarks">Initial value of the TotalMarks property.</param>
        public static Student CreateStudent(global::System.Int32 studentID, global::System.String studentName, global::System.Int32 totalMarks)
        {
            Student student = new Student();
            student.StudentID = studentID;
            student.StudentName = studentName;
            student.TotalMarks = totalMarks;
            return student;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 StudentID
        {
            get
            {
                return _StudentID;
            }
            set
            {
                if (_StudentID != value)
                {
                    OnStudentIDChanging(value);
                    ReportPropertyChanging("StudentID");
                    _StudentID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("StudentID");
                    OnStudentIDChanged();
                }
            }
        }
        private global::System.Int32 _StudentID;
        partial void OnStudentIDChanging(global::System.Int32 value);
        partial void OnStudentIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String StudentName
        {
            get
            {
                return _StudentName;
            }
            set
            {
                OnStudentNameChanging(value);
                ReportPropertyChanging("StudentName");
                _StudentName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("StudentName");
                OnStudentNameChanged();
            }
        }
        private global::System.String _StudentName;
        partial void OnStudentNameChanging(global::System.String value);
        partial void OnStudentNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TotalMarks
        {
            get
            {
                return _TotalMarks;
            }
            set
            {
                OnTotalMarksChanging(value);
                ReportPropertyChanging("TotalMarks");
                _TotalMarks = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TotalMarks");
                OnTotalMarksChanged();
            }
        }
        private global::System.Int32 _TotalMarks;
        partial void OnTotalMarksChanging(global::System.Int32 value);
        partial void OnTotalMarksChanged();

        #endregion

    
    }

    #endregion

    
}
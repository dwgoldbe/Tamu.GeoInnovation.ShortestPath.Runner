﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.3038.
// 
namespace USC.GISResearchLab.ShortestPath.Core
{
  using System.Diagnostics;
  using System.Web.Services;
  using System.ComponentModel;
  using System.Web.Services.Protocols;
  using System;
  using System.Xml.Serialization;


  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "ShortestPathServiceSoap", Namespace = "http://shortestpath.usc.edu/service/")]
  public partial class ShortestPathService : System.Web.Services.Protocols.SoapHttpClientProtocol
  {

    private System.Threading.SendOrPostCallback IsAliveOperationCompleted;

    private System.Threading.SendOrPostCallback SetupOperationCompleted;

    private System.Threading.SendOrPostCallback CalculateOperationCompleted;

    /// <remarks/>
    public ShortestPathService()
    {
      this.Url = "http://localhost/ShortestPathService/ShortestPathService.asmx";
    }

    /// <remarks/>
    public event IsAliveCompletedEventHandler IsAliveCompleted;

    /// <remarks/>
    public event SetupCompletedEventHandler SetupCompleted;

    /// <remarks/>
    public event CalculateCompletedEventHandler CalculateCompleted;

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://shortestpath.usc.edu/service/IsAlive", RequestNamespace = "http://shortestpath.usc.edu/service/", ResponseNamespace = "http://shortestpath.usc.edu/service/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public bool IsAlive()
    {
      object[] results = this.Invoke("IsAlive", new object[0]);
      return ((bool)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginIsAlive(System.AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("IsAlive", new object[0], callback, asyncState);
    }

    /// <remarks/>
    public bool EndIsAlive(System.IAsyncResult asyncResult)
    {
      object[] results = this.EndInvoke(asyncResult);
      return ((bool)(results[0]));
    }

    /// <remarks/>
    public void IsAliveAsync()
    {
      this.IsAliveAsync(null);
    }

    /// <remarks/>
    public void IsAliveAsync(object userState)
    {
      if ((this.IsAliveOperationCompleted == null))
      {
        this.IsAliveOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsAliveOperationCompleted);
      }
      this.InvokeAsync("IsAlive", new object[0], this.IsAliveOperationCompleted, userState);
    }

    private void OnIsAliveOperationCompleted(object arg)
    {
      if ((this.IsAliveCompleted != null))
      {
        System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
        this.IsAliveCompleted(this, new IsAliveCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
      }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://shortestpath.usc.edu/service/Setup", RequestNamespace = "http://shortestpath.usc.edu/service/", ResponseNamespace = "http://shortestpath.usc.edu/service/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string Setup(string navteqDataSourceConnectionString, int maxMiles2Go, int maxHours2Go)
    {
      object[] results = this.Invoke("Setup", new object[] {
                        navteqDataSourceConnectionString,
                        maxMiles2Go,
                        maxHours2Go});
      return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginSetup(string navteqDataSourceConnectionString, int maxMiles2Go, int maxHours2Go, System.AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("Setup", new object[] {
                        navteqDataSourceConnectionString,
                        maxMiles2Go,
                        maxHours2Go}, callback, asyncState);
    }

    /// <remarks/>
    public string EndSetup(System.IAsyncResult asyncResult)
    {
      object[] results = this.EndInvoke(asyncResult);
      return ((string)(results[0]));
    }

    /// <remarks/>
    public void SetupAsync(string navteqDataSourceConnectionString, int maxMiles2Go, int maxHours2Go)
    {
      this.SetupAsync(navteqDataSourceConnectionString, maxMiles2Go, maxHours2Go, null);
    }

    /// <remarks/>
    public void SetupAsync(string navteqDataSourceConnectionString, int maxMiles2Go, int maxHours2Go, object userState)
    {
      if ((this.SetupOperationCompleted == null))
      {
        this.SetupOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetupOperationCompleted);
      }
      this.InvokeAsync("Setup", new object[] {
                        navteqDataSourceConnectionString,
                        maxMiles2Go,
                        maxHours2Go}, this.SetupOperationCompleted, userState);
    }

    private void OnSetupOperationCompleted(object arg)
    {
      if ((this.SetupCompleted != null))
      {
        System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
        this.SetupCompleted(this, new SetupCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
      }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://shortestpath.usc.edu/service/Calculate", RequestNamespace = "http://shortestpath.usc.edu/service/", ResponseNamespace = "http://shortestpath.usc.edu/service/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public ShortestPathResult Calculate(ShortestPathQuery query)
    {
      object[] results = this.Invoke("Calculate", new object[] {
                        query});
      return ((ShortestPathResult)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginCalculate(ShortestPathQuery query, System.AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("Calculate", new object[] {
                        query}, callback, asyncState);
    }

    /// <remarks/>
    public ShortestPathResult EndCalculate(System.IAsyncResult asyncResult)
    {
      object[] results = this.EndInvoke(asyncResult);
      return ((ShortestPathResult)(results[0]));
    }

    /// <remarks/>
    public void CalculateAsync(ShortestPathQuery query)
    {
      this.CalculateAsync(query, null);
    }

    /// <remarks/>
    public void CalculateAsync(ShortestPathQuery query, object userState)
    {
      if ((this.CalculateOperationCompleted == null))
      {
        this.CalculateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCalculateOperationCompleted);
      }
      this.InvokeAsync("Calculate", new object[] {
                        query}, this.CalculateOperationCompleted, userState);
    }

    private void OnCalculateOperationCompleted(object arg)
    {
      if ((this.CalculateCompleted != null))
      {
        System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
        this.CalculateCompleted(this, new CalculateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
      }
    }

    /// <remarks/>
    public new void CancelAsync(object userState)
    {
      base.CancelAsync(userState);
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://shortestpath.usc.edu/service/")]
  public partial class ShortestPathQuery
  {

    /// <remarks/>
    public double FromLat;

    /// <remarks/>
    public double FromLon;

    /// <remarks/>
    public double ToLat;

    /// <remarks/>
    public double ToLon;

    /// <remarks/>
    public bool ShouldDoShortestTime;

    /// <remarks/>
    public bool ShouldDoShortestDistance;
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://shortestpath.usc.edu/service/")]
  public partial class ShortestPathResult
  {

    /// <remarks/>
    public ShortestPathResultCode Code;

    /// <remarks/>
    public double ShortestDistance;

    /// <remarks/>
    public double ShortestTime;

    /// <remarks/>
    public double TraveledTime;

    /// <remarks/>
    public double TraveledDistance;

    /// <remarks/>
    public string KML;

    /// <remarks/>
    public string Message;
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://shortestpath.usc.edu/service/")]
  public enum ShortestPathResultCode
  {

    /// <remarks/>
    SUCCESS,

    /// <remarks/>
    ERROR,

    /// <remarks/>
    UNKNOWN,
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  public delegate void IsAliveCompletedEventHandler(object sender, IsAliveCompletedEventArgs e);

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  public partial class IsAliveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
  {

    private object[] results;

    internal IsAliveCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
      base(exception, cancelled, userState)
    {
      this.results = results;
    }

    /// <remarks/>
    public bool Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return ((bool)(this.results[0]));
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  public delegate void SetupCompletedEventHandler(object sender, SetupCompletedEventArgs e);

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  public partial class SetupCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
  {

    private object[] results;

    internal SetupCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
      base(exception, cancelled, userState)
    {
      this.results = results;
    }

    /// <remarks/>
    public string Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return ((string)(this.results[0]));
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  public delegate void CalculateCompletedEventHandler(object sender, CalculateCompletedEventArgs e);

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  public partial class CalculateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
  {

    private object[] results;

    internal CalculateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
      base(exception, cancelled, userState)
    {
      this.results = results;
    }

    /// <remarks/>
    public ShortestPathResult Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return ((ShortestPathResult)(this.results[0]));
      }
    }
  }
}
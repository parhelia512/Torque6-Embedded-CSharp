using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiPopupTextListCtrl : GuiTextListCtrl
   {
      
      public GuiPopupTextListCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiPopupTextListCtrlCreateInstance());
      }

      public GuiPopupTextListCtrl(uint pId) : base(pId)
      {
      }

      public GuiPopupTextListCtrl(string pName) : base(pName)
      {
      }

      public GuiPopupTextListCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiPopupTextListCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiPopupTextListCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiPopupTextListCtrlCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}
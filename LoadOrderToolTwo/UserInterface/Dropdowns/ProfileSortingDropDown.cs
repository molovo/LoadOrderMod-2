﻿using Extensions;
using LoadOrderToolTwo.Domain.Enums;
using LoadOrderToolTwo.Utilities.Managers;

using SlickControls;
using SlickControls.Controls.Form;

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LoadOrderToolTwo.UserInterface.Dropdowns;
internal class ProfileSortingDropDown : SlickSelectionDropDown<ProfileSorting>
{
    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);

        if (Live)
        {
            Items = Enum.GetValues(typeof(ProfileSorting)).Cast<ProfileSorting>().ToArray();
        }
    }

    protected override void UIChanged()
    {
        Font = UI.Font(9.75F);
        Margin = UI.Scale(new Padding(5), UI.FontScale);
        Padding = UI.Scale(new Padding(5), UI.FontScale);
    }

    protected override void PaintItem(PaintEventArgs e, Rectangle rectangle, Color foreColor, HoverState hoverState, ProfileSorting item)
    {
        var text = LocaleHelper.GetGlobalText($"Sorting_{item}");
        var color = FormDesign.Design.ForeColor;

        using var icon = ImageManager.GetIcon(GetIcon(item)).Color(foreColor);

        e.Graphics.DrawImage(icon, rectangle.Align(icon.Size, ContentAlignment.MiddleLeft));

        var textRect = new Rectangle(rectangle.X + icon.Width + Padding.Left, rectangle.Y + (rectangle.Height - Font.Height) / 2, 0, Font.Height);

        textRect.Width = rectangle.Width - textRect.X;

        e.Graphics.DrawString(text, Font, new SolidBrush(foreColor), textRect, new StringFormat { LineAlignment = StringAlignment.Center, Trimming = StringTrimming.EllipsisCharacter });
    }

    private string GetIcon(ProfileSorting item)
    {
        return nameof(Properties.Resources.I_Sort);
    }
}

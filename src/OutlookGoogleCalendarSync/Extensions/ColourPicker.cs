﻿using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OutlookGoogleCalendarSync.Extensions {
    public partial class ColourPicker : ComboBox {
        public class ColourInfo {
            public String Text { get; }
            public OlCategoryColor OutlookCategory { get; }
            public Color Colour { get; }

            public ColourInfo(OlCategoryColor category, Color colour, String name = "") {
                this.Text = string.IsNullOrEmpty(name) ? OutlookOgcs.Categories.FriendlyCategoryName(category) : name;
                this.Colour = colour;
                this.OutlookCategory = category;
            }
        }

        public enum ColourType {
            OutlookStandardColours,
            OutlookCategoryColours
        }

        public ColourPicker() {
            DropDownStyle = ComboBoxStyle.DropDownList;
            DrawMode = DrawMode.OwnerDrawFixed;
            DrawItem += ColourPicker_DrawItem;
        }

        public void AddColourItems(ColourType? type) {
            if (type == null)
                Items.Clear();
            if (type == null || type == ColourType.OutlookCategoryColours)
                AddCategoryColours();
            if (type == null || type == ColourType.OutlookStandardColours)
                addStandardColours();
        }

        private void addStandardColours() {
            foreach (KeyValuePair<OlCategoryColor, Color> colour in OutlookOgcs.CategoryMap.Colours) {
                Items.Add(new ColourInfo(colour.Key, colour.Value));
            }
        }

        public void AddCategoryColours() {
            Items.AddRange(OutlookOgcs.Calendar.Categories.DropdownItems().OrderBy(x => x.Text).ToArray());
        }

        public void ColourPicker_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e) {
            if (e.Index >= 0) {
                Boolean enabled = (sender as ComboBox).Enabled;
                // Get the colour
                ColourInfo colour = (ColourInfo)Items[e.Index];

                // Fill background
                (sender as ComboBox).BackColor = enabled ? Color.White : Color.FromArgb(240,240,240);
                e.DrawBackground();

                // Draw colour box
                Rectangle rect = new Rectangle();
                rect.X = e.Bounds.X + 2;
                rect.Y = e.Bounds.Y + 2;
                rect.Width = 18;
                rect.Height = e.Bounds.Height - 5;
                e.Graphics.FillRectangle(new SolidBrush(colour.Colour), rect);
                e.Graphics.DrawRectangle(enabled ? SystemPens.WindowText : SystemPens.InactiveBorder, rect);

                // Write colour name
                Brush brush;
                if ((e.State & DrawItemState.Selected) != DrawItemState.None)
                    brush = enabled ? SystemBrushes.HighlightText : SystemBrushes.InactiveCaptionText;
                else
                    brush = enabled ? SystemBrushes.WindowText : SystemBrushes.InactiveCaptionText;
                e.Graphics.DrawString(colour.Text, Font, brush,
                    e.Bounds.X + rect.X + rect.Width + 2,
                    e.Bounds.Y + ((e.Bounds.Height - Font.Height) / 2));

                // Draw the focus rectangle if appropriate
                if ((e.State & DrawItemState.NoFocusRect) == DrawItemState.None)
                    e.DrawFocusRectangle();
            }
        }

        public new ColourInfo SelectedItem {
            get { return (ColourInfo)base.SelectedItem; }
            set { base.SelectedItem = value; }
        }
    }
}

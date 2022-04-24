// Made by LenaKotik
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sales
{
    public partial class StorageManager : Form
    {
        byte branchCache;
        public StorageManager()
        {
            InitializeComponent();
            OpenBranchButt.Click += OpenBranch;
            AddButt.Click += AddItem;
            AddButt.Paint += RenderPlus;
            SaveButt.Click += Save;
        }
        private void Save(object sender, EventArgs e)
        {
            bool anyErr = false;
            foreach (StorageItemControl i in ItemsBox.Controls.OfType<StorageItemControl>())
            {
                if (i.MatName == "")
                {
                    ItemErr.SetError(i, "Введите значение");
                    i.SetEditable(true);
                    anyErr = true;
                }
            }
            if (!anyErr)
            {
                DataProvider.UpdateStorage(branchCache, ItemsBox.Controls.OfType<StorageItemControl>()
                    .Select(x => new StorageItem()
                    {
                        Material = x.MatName,
                        Amount = (short)x.Amount
                    }).ToList());
                this.Close();
            }
        }
        private void RenderPlus(object sender, PaintEventArgs e)
        {
            int offset = 10;
            Rectangle r = new Rectangle(e.ClipRectangle.X+offset,e.ClipRectangle.Y+offset,e.ClipRectangle.Width - offset*2, e.ClipRectangle.Height - offset*2);
            e.Graphics.DrawLine(new Pen(SystemColors.ControlText, 5f), r.X, r.Y + r.Height/2, r.X + r.Width, r.Y + r.Height/2);
            e.Graphics.DrawLine(new Pen(SystemColors.ControlText, 5f), r.X + r.Width/2, r.Y, r.X + r.Width/2, r.Y + r.Height);
        }
        private void AddItem(object sender, EventArgs e)
        {
            StorageItemControl item = new(true)
            {
                Top = 25 + ItemsBox.Controls.Count * 100
            };
            item.Deleted += RelocateItems;
            ItemsBox.Controls.Add(item);
        }
        private void OpenBranch(object sender, EventArgs e)
        {
            ItemsBox.Controls.Clear();
            int index = 0;
            foreach (StorageItem i in DataProvider.GetStorageItems(branchCache = (byte)BranchUpDown.Value))
            {
                StorageItemControl item = new(i)
                {
                    Top = 25 + index * 100
                };
                item.Deleted += RelocateItems;
                ItemsBox.Controls.Add(item);
                index++;
            }
        }
        private void RelocateItems(object sender, EventArgs e)
        {
            for (int i = 0; i < ItemsBox.Controls.Count; i++)
                ItemsBox.Controls[i].Top = 25 + i * 100;
        }
    }
}

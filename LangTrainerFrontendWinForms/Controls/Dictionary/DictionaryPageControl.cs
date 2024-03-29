﻿
using LangTrainerClientModel.Services;
using LangTrainerFrontendWinForms.Controls.Dictionary;
using LangTrainerFrontendWinForms.Controls.Dictionary.Items;
using LangTrainerFrontendWinForms.Model;
using LangTrainerFrontendWinForms.Service;
using LangTrainerFrontendWinForms.Services;
using LangTrainerServices.Services;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class DictionaryPageControl : UserControl, ISettingsСonsumer
    {
        private readonly ProgressService _prServ;

        public DictionaryPageControl()
        {
            InitializeComponent();
            _prServ = new ProgressService(_progressBar);
            _searchControl.Changed += SearchControlOnTextChanged;
            _searchControl.Clear += _searchControl_Clear;

            LangFilterService.GetInstance().Changed += FilterChanged;
        }

        private void _searchControl_Clear(object? sender, EventArgs e)
        {
            Invoke(_itemsTableLayout.Controls.Clear);
        }

        private async void FilterChanged(object? sender, EventArgs e)
        {
            await RunSeach();
        }

        private async Task RunSeach()
        {
            if (!string.IsNullOrEmpty(_searchControl.SearchString))
            {
                _prServ.Switch(true);
                var filterData = LangFilterService.GetInstance().Filter;
                await GetDataAndShow(_searchControl.SearchString, filterData.LangId, filterData.TrLangId);
            }
        }

        public void Init()
        {
            LangFilterService.GetInstance().Changed += DictionaryControl_Changed;
        }

        private async void DictionaryControl_Changed(object? sender, EventArgs e)
        {
            await RunSeach();
        }

        private async void SearchControlOnTextChanged(object? sender, SearchStringChangedEventArgs e)
        {
            await RunSeach();
        }

        private void ShowData(FindResult data)
        {
            Invoke(() =>
            {
                _itemsTableLayout.SuspendLayout();
                _itemsTableLayout.Controls.Clear();
                if (data.Items == null || data.Items.Count == 0)
                {
                    var ctr = new WordNotFoundItemControl();
                    ctr.Dock = DockStyle.Fill;
                    _itemsTableLayout.Controls.Add(ctr);
                    ctr.OnLoadWordClick += OnLoadWordClick;
                    ctr.Init(data.SearchString);
                }
                else
                {
                    var i = 0;
                    _itemsTableLayout.RowStyles.Clear();

                    foreach (var item in data.Items)
                    {
                        var ctr = new WordInDictionaryItemControl();
                        ctr.Dock = DockStyle.Fill;
                        _itemsTableLayout.Controls.Add(ctr);
                        _itemsTableLayout.RowStyles.Add(new RowStyle() { Height = 40, SizeType = SizeType.Absolute});
                        _itemsTableLayout.SetRow(ctr, i++);
                        ctr.Init(item);
                    }

                    _itemsTableLayout.RowStyles.Add(new RowStyle()
                    {
                        Height = 100,
                        SizeType = SizeType.Percent
                    });
                }
                _itemsTableLayout.ResumeLayout();
            });
        }

        private async void OnLoadWordClick(object? sender, OnLoadWordEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Word))
            {
                _prServ.Switch(true);

                var langServ = LangService.GetInstance();
                var res = await langServ.LoadInBase(
                    new WordInfo(e.Word, e.LanguageId));
                if (res.WordFound)
                {
                    NotifyService.GetInstance().ShowMessage("Word found");
                    //var filterData = _langFilter.Data;
                    var filterData = LangFilterService.GetInstance().Filter;
                    await GetDataAndShow(e.Word, filterData.LangId, filterData.TrLangId);
                }
                else
                {
                    NotifyService.GetInstance().ShowMessage("Word not found");
                    _prServ.Switch(false);
                }
            }
        }

        private async Task GetDataAndShow(string str, Guid? langId, Guid? trLangId)
        {
            if (!string.IsNullOrEmpty(str))
            {
                try
                {
                    var langServ = LangService.GetInstance();
                    var res = await langServ.FindInDictionary(str, langId, trLangId);
                    ShowData(res);
                    _prServ.Switch(false);
                }
                catch (Exception ex)
                {
                    NotifyService.GetInstance().ShowMessage(ex.Message);
                }
            }
        }

        public void InitSettings(Settings settings, string parentKey)
        {
            //_langFilter.InitSettings(settings, null);
        }

        public void SaveSettings(Settings settings, string parentKey)
        {
            //_langFilter.SaveSettings(settings, null);
        }

    }
}

import { PACSTemplatePage } from './app.po';

describe('PACS App', function() {
  let page: PACSTemplatePage;

  beforeEach(() => {
    page = new PACSTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

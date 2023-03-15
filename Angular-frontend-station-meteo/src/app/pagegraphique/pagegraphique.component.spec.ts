import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PagegraphiqueComponent } from './pagegraphique.component';

describe('PagegraphiqueComponent', () => {
  let component: PagegraphiqueComponent;
  let fixture: ComponentFixture<PagegraphiqueComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PagegraphiqueComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PagegraphiqueComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
